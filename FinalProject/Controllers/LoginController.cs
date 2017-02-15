using FinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Views
{
    public class LoginController : Controller
    {
        private IUserManager _userManager;

        public LoginController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            User validateUser = _userManager.GetAllUsers.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (validateUser != null)
            {
                Session["User"] = validateUser;
                return RedirectToAction("ViewTeams", "Bet");
            }
            else
            {
                // TO DO: Error Checking
                return View();
            }
        }

        
    }
}