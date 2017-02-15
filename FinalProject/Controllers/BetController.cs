using FinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class BetController : Controller
    {
        private ITeamManager _teamManager;
        private IBetManager _betManager;

        public BetController(ITeamManager teamManager, IBetManager betManager)
        {
            _teamManager = teamManager;
            _betManager = betManager;
        }

        public ActionResult ViewTeams()
        {
            return View(_teamManager.GetAllTeams);
        }

        public ActionResult Bet(string amountBid, int teamID)
        {
            //decimal bidAmount = decimal.Parse(amountBid);
            if(amountBid == "")
            {
                return RedirectToAction("ViewTeams");
            }
            //intead of update team db table we are adding to bet db table
            User user = Session["User"] as User;

            Team team = _teamManager.GetAllTeams.FirstOrDefault(x => x.TeamId == teamID);
             _betManager.AddBet(user, team, amountBid);
            //_teamManager.UpdateTeamBid(team.TeamId, bidAmount);

            //_teamManager.AddTeam(team);
            return RedirectToAction("ViewBets","CurrentBets");
        }
    }
}