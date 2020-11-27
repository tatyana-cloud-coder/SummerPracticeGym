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
        private readonly IHallLogic _hallLogic;
        public HallController(IHallLogic hallLogic)
        {
            _hallLogic = hallLogic;
        }
        public ActionResult GetHalls()
        {
            var halls = _hallLogic.GetHalls();
            return View(halls);
        }
        public ActionResult DeleteHall(int idHall)
        {
            _hallLogic.RemoveHall(idHall);
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
            if (ModelState.IsValid && _hallLogic.GetNeedHalls(hall.NameOfHall) !=null)
            {
                ModelState.AddModelError("Name", "Зал с таким названием уже существует!");
            }
            if (ModelState.IsValid)
            {
                _hallLogic.AddHall(hall);
                return RedirectToAction("GetHalls");
            } else
            {
                return View();
            }
        }
    }
}