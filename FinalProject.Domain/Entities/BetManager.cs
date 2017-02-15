using FinalProject.Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities
{
    public class BetManager : IBetManager
    {
        private IBetRepository _betRepository;

        public BetManager(IBetRepository betRepository)
        {
            _betRepository = betRepository;
        }

        public IEnumerable<Bet> GetAllBets
        {
            get
            {
                return _betRepository.BetTable;
            }
        }

        public void AddBet(User user, Team team, string amountBid)
        {
            Bet bet = new Bet();
            bet.UserName = user.Username;
            bet.TeamName = team.TeamName;
            bet.OpposingTeamName = team.OpposingTeamName;
            bet.BettingOdds = team.BettingOdds;
            bet.isFavourite = team.isFavourite;
            bet.AmountBid = decimal.Parse(amountBid);
            bet.BetPayout = bet.Payout(bet);

            _betRepository.CreateBet(bet);

        }
    }
}
