using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym.BLL;
using Gym.BLL.Interfaces;
using Entities;
namespace WebPL.Controllers.Clients
{
    public class ClientController : Controller
    {
        private readonly IClientLogic clientLogic;
        private readonly ICoachLogic coachLogic;
    
        public ClientController()
        {
            clientLogic = new ClientLogic();
            coachLogic = new CoachLogic();
        }
        public ActionResult GetClients()
        {
            var clients = clientLogic.GetClients();
            return View(clients);
        }
        public ActionResult DeleteClient(int idClient)
        {
            clientLogic.RemoveClient(idClient);
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
                && coachLogic.SelectIdNeedCoach(client.FirstNameOfFavoriteCoach, client.LastNameOfFavoriteCoach) == -1)
            {
                ModelState.AddModelError("FirstNameOfFavoriteCoach", "Тренера с таким именем и такой фамилией не существует");
                ModelState.AddModelError("LastNameOfFavoriteCoach", "Тренера с таким именем и такой фамилией не существует");
            }
            if (ModelState.IsValid)
            {
                clientLogic.AddClient(client);
                return RedirectToAction("GetClients");
            } else
            {
                return View();
            }
        }
    }
}