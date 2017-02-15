using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities
{
    public class Bet
    {

        public int BetId { get; set; }
        public string UserName { get; set; }
        public string TeamName { get; set; }
        public string OpposingTeamName { get; set; }
        public string BettingOdds { get; set; }
        public bool isFavourite { get; set; }
        public decimal AmountBid { get; set; }
        public decimal BetPayout { get; set; }


        /// <summary>
        /// to convert fractional UK based betting odds (eg. 13/5) you must divide the numerator by the denominator
        /// then add 1.00 to get a decimal that can be used to determine payout
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        public decimal Odds(Bet bet)
        {
            string[] tokens = bet.BettingOdds.Split('/');
            decimal v1 = decimal.Parse(tokens[0]);
            decimal v2 = decimal.Parse(tokens[1]);
            decimal ratio = (v1 / v2) + 1.00m;
            return ratio;
        }

        public decimal Payout(Bet bet)
        {
            decimal AmountWon = Odds(bet) * bet.AmountBid;
            return AmountWon;
        }
    }
}
