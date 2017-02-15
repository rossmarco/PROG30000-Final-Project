using FinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class CurrentBetsController : Controller
    {
        private IBetManager _betManager;

        public CurrentBetsController( IBetManager betManager)
        {
            _betManager = betManager;
        }

        // GET: CurrentBets
        public ActionResult ViewBets()
        {
            return View(_betManager.GetAllBets);
        }
    }
}