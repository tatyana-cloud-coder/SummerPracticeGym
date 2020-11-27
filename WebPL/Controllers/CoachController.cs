using System.Web.Mvc;
using Gym.BLL.Interfaces;
using Entities;
namespace WebPL.Controllers.Coaches
{
    public class CoachController : Controller
    {
        private readonly ICoachLogic _coachLogic;
        private readonly IHallLogic _hallLogic;
        public CoachController(ICoachLogic coachLogic, IHallLogic hallLogic)
        {
            _coachLogic = coachLogic;
            _hallLogic = hallLogic;
        }
        public ActionResult GetCoaches()
        {
            var coaches = _coachLogic.GetCoaches();
            return View(coaches);
        }
        public ActionResult DeleteCoach(int idCoach)
        {
            _coachLogic.RemoveCoach(idCoach);
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
            if (coach.MainHall!= null && _hallLogic.GetNeedHalls(coach.MainHall)==null)
            {
                ModelState.AddModelError("MainHall", "Зала с таким названием не существует");
            }
            if (ModelState.IsValidField("FirstName") && ModelState.IsValidField("LastName") 
                && _coachLogic.SelectIdNeedCoach(coach.FirstName, coach.LastName) != null)
            {
                ModelState.AddModelError("FirstName", "Тренер с таким именем и такой  фамилией уже существует");
                ModelState.AddModelError("LastName", "Тренер с таким именем и такой  фамилией уже существует");
            }
            if (ModelState.IsValid)
            {
                _coachLogic.AddCoach(coach);
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
            var tmp = _coachLogic.SearchCoach(Name);
            return View(tmp);
        }
    }
}