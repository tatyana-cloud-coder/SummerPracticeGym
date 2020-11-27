using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym.BLL;
using Gym.BLL.Interfaces;
using Entities;
namespace WebPL.Controllers.Groups
{
    public class GroupController : Controller
    {
        private readonly IGroupLogic _groupLogic;
        public GroupController(IGroupLogic groupLogic)
        {
            _groupLogic = groupLogic;
        }
        public ActionResult GetGroups()
        {
            var groups = _groupLogic.GetGroups();
            return View(groups);
        }
        public ActionResult DeleteGroup (int idGroup)
        {
            _groupLogic.RemoveGroup(idGroup);
            return RedirectToAction("GetGroups");
        }
        [HttpGet]
        public ActionResult AddGroup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddGroup (Group group)
        {
            if (ModelState.IsValidField("TimeToBegin") && ModelState.IsValidField("TimeToEnd") 
                && (group.TimeToEnd -group.TimeToBegin).Hours < 2)
            {
                ModelState.AddModelError("TimeToBegin", "Тренировочное время должно быть не менее двух часов");
                ModelState.AddModelError("TimeToEnd", "Тренировочное время должно быть не менее двух часов");
            } 
            if (ModelState.IsValidField("Name") && _groupLogic.GetNeedGroups(group.Name).Any())
            {
                ModelState.AddModelError("Name", "Группа с таким названием уже существует!");
            }
            if (ModelState.IsValid)
            {
                _groupLogic.AddGroup(group);
                return RedirectToAction("GetGroups");
            } else
            {
                return View();
            }
        }
    }
}