using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using Gym.BLL;
using Gym.BLL.Interfaces;
namespace WebPL.Controllers.Users
{
    public class UserController : Controller
    {
        private readonly IUserLogic _userLogic;
        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        [HttpGet]
        public ActionResult SignIn()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult SignIn(User user)
        {
            if (ModelState.IsValidField("Login") && ModelState.IsValidField("Password")
                && !_userLogic.GetNeedUsers(user.Login, user.Password.GetHashCode()).Any())
            {

                ModelState.AddModelError("Login", "Пользователя с такими параметрами авторизации не существует");
                ModelState.AddModelError("Password", "Пользователя с такими параметрами авторизации не существует");
            }
            if (ModelState.IsValidField("Login") && ModelState.IsValidField("Password"))
            {
                User MyProfile = _userLogic.GetNeedUsers(user.Login, user.Password.GetHashCode()).FirstOrDefault();
                TempData["ID"] = MyProfile.IDUser;
                TempData["FirstName"] = MyProfile.FirstName;
                TempData["LastName"] = MyProfile.LastName;
                TempData["TelephoneNumber"] = MyProfile.TelephoneNumber;
                TempData["Email"] = MyProfile.EmailAddress;
                TempData["Login"] = user.Login;
                return RedirectToAction("GetModels", "MyGym");
            } else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User user)
        {
            if (_userLogic.GetNeedUsers(user.Login, user.Password.GetHashCode()).Any())
            {
                ModelState.AddModelError("Login", "Пользователь с такими параметрами авторизации уже существует");
                ModelState.AddModelError("Password", "Пользователь с такими параметрами авторизации уже существует");
            }
            if (ModelState.IsValid)
            {
                _userLogic.RegisterUser(user);
                return RedirectToAction("SignIn");
            } else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult GetProfile()
        { 
            return View();
        }
        [HttpGet]
        public ActionResult UpdateFirstName()
        {
            return View();
        }
        [HttpPost] 
        public ActionResult UpdateFirstName(User user)
        {
            if (ModelState.IsValidField("FirstName"))
            {
                _userLogic.UpdateFirstName((int)TempData.Peek("ID"), user.FirstName);
                TempData["FirstName"] = user.FirstName;
                return RedirectToAction("GetProfile");
            } else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult UpdateLastName ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateLastName (User user)
        {
            if (ModelState.IsValidField("LastName"))
            {
                _userLogic.UpdateLastName((int)TempData.Peek("ID"), user.LastName);
                TempData["LastName"] = user.LastName;
                return RedirectToAction("GetProfile");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult UpdateTelephoneNumber()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateTelephoneNumber (User user)
        {
            if (ModelState.IsValidField("TelephoneNumber"))
            {
                _userLogic.UpdateTelephoneNumber((int)TempData.Peek("ID"), user.TelephoneNumber);
                TempData["TelephoneNumber"] = user.TelephoneNumber;
                return RedirectToAction("GetProfile");
            }
            else
            {
                return View();
            }
        }
    }
}