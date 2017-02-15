using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities
{
    public interface IBetManager
    {
        IEnumerable<Bet> GetAllBets { get; }

        void AddBet(User user,Team team, string amountBid);
    }
}
