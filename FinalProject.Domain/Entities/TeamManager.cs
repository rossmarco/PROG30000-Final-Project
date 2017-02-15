using FinalProject.Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities
{
    public class TeamManager : ITeamManager
    {
        private ITeamRepository _teamRepository;

        public TeamManager(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public IEnumerable<Team> GetAllTeams
        {
            get
            {
                return _teamRepository.TeamTable;
            }
        }

        public void AddTeam(Team team)
        {
            _teamRepository.CreateTeam(team);
        }

        public void UpdateTeamBid(int id, decimal amount)
        {
            Team team = _teamRepository.TeamTable.FirstOrDefault(x => x.TeamId == id);

            _teamRepository.UpdateTeamBidInfo(team, amount);
        }
    }
}
