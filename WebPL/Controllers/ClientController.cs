using System.Web.Mvc;
using Gym.BLL;
using Gym.BLL.Interfaces;
using Entities;
namespace WebPL.Controllers.Clients
{
    public class ClientController : Controller
    {
        private readonly IClientLogic _clientLogic;
        private readonly ICoachLogic _coachLogic;
    
        public ClientController(IClientLogic clientLogic, ICoachLogic coachLogic)
        {
            _clientLogic = clientLogic;
            _coachLogic = coachLogic;
        }
        public ActionResult GetClients()
        {   
            var clients = _clientLogic.GetClients();
            return View(clients);
        }
        public ActionResult DeleteClient(int idClient)
        {
            _clientLogic.RemoveClient(idClient);
            return RedirectToAction("GetClients");
        }
        [HttpGet]
        public ActionResult AddClient()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddClient(Client client)
        {
            if (client.FirstNameOfFavoriteCoach!=null && client.LastNameOfFavoriteCoach != null 
                && _coachLogic.SelectIdNeedCoach(client.FirstNameOfFavoriteCoach, client.LastNameOfFavoriteCoach) == null)
            {
                ModelState.AddModelError("FirstNameOfFavoriteCoach", "Тренера с таким именем и такой фамилией не существует");
                ModelState.AddModelError("LastNameOfFavoriteCoach", "Тренера с таким именем и такой фамилией не существует");
            }
            if (ModelState.IsValid)
            {
                _clientLogic.AddClient(client);
                return RedirectToAction("GetClients");
            } else
            {
                return View();
            }
        }
    }
}