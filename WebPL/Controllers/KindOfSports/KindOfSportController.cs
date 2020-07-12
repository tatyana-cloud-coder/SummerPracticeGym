using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym.BLL;
using Gym.BLL.Interfaces;
using Entities;
namespace WebPL.Controllers.KindOfSports
{
    public class KindOfSportController : Controller
    {
        private readonly IKindOfSportLogic kindOfSportLogic;
        public KindOfSportController()
        {
            kindOfSportLogic = new KindOfSportLogic();
        }
        public ActionResult GetSports()
        {
            var sports = kindOfSportLogic.GetKindOfSports();
            return View(sports);
        }
        public ActionResult DeleteSport(int idSport)
        {
            kindOfSportLogic.RemoveKindOfSport(idSport);
            return RedirectToAction("GetSports");
        }
        [HttpGet]
        public ActionResult AddSport()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSport (KindOfSport kindOfSport)
        {
            if (ModelState.IsValid && kindOfSportLogic.GetNeedKindOfSports(kindOfSport.NameOfKind).Any())
            {
                ModelState.AddModelError("NameOfKind", "Вид спорта с таким названием уже существует!");
            }
            if (ModelState.IsValid)
            {
                kindOfSportLogic.AddKindOfSport(kindOfSport);
                return RedirectToAction("GetSports");
            } else
            {
                return View();
            }
        }
    }
}