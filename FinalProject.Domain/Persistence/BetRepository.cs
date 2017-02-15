using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Domain.Entities;

namespace FinalProject.Domain.Persistence
{
    public class BetRepository : IBetRepository
    {
        private FinalProjectDbContext _dbContext;

        public BetRepository()
        {
            _dbContext = new FinalProjectDbContext();
        }

        public IEnumerable<Bet> BetTable
        {
            get
            {
                return _dbContext.Bet;
            }
        }

        public void CreateBet(Bet bet)
        {
            if (bet.BetId == 0)
            {
                _dbContext.Bet.Add(bet);
            }

            _dbContext.SaveChanges();
        }
    }
}
