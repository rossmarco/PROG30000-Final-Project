using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string OpposingTeamName { get; set; }
        public string BettingOdds { get; set; }
        public bool isFavourite { get; set; }

        public void Update(decimal newBid)
        {
           // this.AmountBid = newBid;
        } 

    }
}
