using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym.BLL;
using Gym.BLL.Interfaces;
using Entities;
namespace WebPL.Controllers.Halls
{
    public class HallController : Controller
    {
        private readonly IHallLogic hallLogic;
        public HallController()
        {
            hallLogic = new HallLogic();
        }
        public ActionResult GetHalls()
        {
            var halls = hallLogic.GetHalls();
            return View(halls);
        }
        public ActionResult DeleteHall(int idHall)
        {
            hallLogic.RemoveHall(idHall);
            return RedirectToAction("GetHalls");
        }
        [HttpGet]
        public ActionResult AddHall()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddHall(Hall hall)
        {
            if (ModelState.IsValid && hallLogic.GetNeedHalls(hall.NameOfHall) !=-1)
            {
                ModelState.AddModelError("Name", "Зал с таким названием уже существует!");
            }
            if (ModelState.IsValid)
            {
                hallLogic.AddHall(hall);
                return RedirectToAction("GetHalls");
            } else
            {
                return View();
            }
        }
    }
}