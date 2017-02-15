using FinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Persistence
{
    public interface IBetRepository
    {
        IEnumerable<Bet> BetTable { get; }

        void CreateBet(Bet bet);
    }
}
