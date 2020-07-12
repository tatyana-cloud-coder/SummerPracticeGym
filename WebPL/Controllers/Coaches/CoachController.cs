using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym.BLL;
using Gym.BLL.Interfaces;
using Entities;
namespace WebPL.Controllers.Coaches
{
    public class CoachController : Controller
    {
        private readonly ICoachLogic coachLogic;
        private readonly IHallLogic hallLogic;
        public CoachController()
        {
            coachLogic = new CoachLogic();
            hallLogic = new HallLogic();
        }
        public ActionResult GetCoaches()
        {
            var coaches = coachLogic.GetCoaches();
            return View(coaches);
        }
        public ActionResult DeleteCoach(int idCoach)
        {
            coachLogic.RemoveCoach(idCoach);
            return RedirectToAction("GetCoaches");
        }
        [HttpGet]
        public ActionResult AddCoach()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCoach(Coach coach)
        {
            if (coach.MainHall!= null && hallLogic.GetNeedHalls(coach.MainHall)==-1)
            {
                ModelState.AddModelError("MainHall", "Зала с таким названием не существует");
            }
            if (ModelState.IsValidField("FirstName") && ModelState.IsValidField("LastName") 
                && coachLogic.SelectIdNeedCoach(coach.FirstName, coach.LastName) != -1)
            {
                ModelState.AddModelError("FirstName", "Тренер с таким именем и такой  фамилией уже существует");
                ModelState.AddModelError("LastName", "Тренер с таким именем и такой  фамилией уже существует");
            }
            if (ModelState.IsValid)
            {
                coachLogic.AddCoach(coach);
                return RedirectToAction("GetCoaches");
            } else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult SearchCoach(string Name)
        {
            ViewData["searchpattern"] = Name;
            var tmp = coachLogic.SearchCoach(Name);
            return View(tmp);
        }
    }
}