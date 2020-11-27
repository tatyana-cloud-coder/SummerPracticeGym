using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
namespace WebPL.Controllers.MyGym
{
    public class MyGymController : Controller
    {
        public MyGymController() { }
        public ActionResult GetModels()
        {
            return View();
        }
       
    }
}