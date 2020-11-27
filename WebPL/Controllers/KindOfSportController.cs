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
        private readonly IKindOfSportLogic _kindOfSportLogic;
        public KindOfSportController(IKindOfSportLogic kindOfSportLogic)
        {
            _kindOfSportLogic = kindOfSportLogic;
        }
        public ActionResult GetSports()
        {
            var sports = _kindOfSportLogic.GetKindOfSports();
            return View(sports);
        }
        public ActionResult DeleteSport(int idSport)
        {
            _kindOfSportLogic.RemoveKindOfSport(idSport);
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
            if (ModelState.IsValid && _kindOfSportLogic.GetNeedKindOfSports(kindOfSport.NameOfKind).Any())
            {
                ModelState.AddModelError("NameOfKind", "Вид спорта с таким названием уже существует!");
            }
            if (ModelState.IsValid)
            {
                _kindOfSportLogic.AddKindOfSport(kindOfSport);
                return RedirectToAction("GetSports");
            } else
            {
                return View();
            }
        }
    }
}