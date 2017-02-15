using FinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class BidController : Controller
    {
        private ITeamManager _teamManager;

        public BidController(ITeamManager teamManager)
        {
            _teamManager = teamManager;
        }

        public ActionResult ViewTeams()
        {
            return View(_teamManager.GetAllTeams);
        }
    }
}