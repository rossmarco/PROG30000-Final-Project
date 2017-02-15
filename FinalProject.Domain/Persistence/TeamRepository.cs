using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Domain.Entities;

namespace FinalProject.Domain.Persistence
{
    public class TeamRepository : ITeamRepository
    {
        private FinalProjectDbContext _dbContext;

        public TeamRepository()
        {
            _dbContext = new FinalProjectDbContext();
        }

        public IEnumerable<Team> TeamTable
        {
            get
            {
                return _dbContext.Team;
            }
        }

        public void CreateTeam(Team team)
        {
            if (team.TeamId == 0)
            {
                _dbContext.Team.Add(team);
            }

            _dbContext.SaveChanges();
        }

        public void UpdateTeamBidInfo(Team team, decimal amount)
        {
            Team updatingTeam = _dbContext.Team.Find(team.TeamId);
            updatingTeam.Update(amount);
            _dbContext.SaveChanges();
        }
    }
}
