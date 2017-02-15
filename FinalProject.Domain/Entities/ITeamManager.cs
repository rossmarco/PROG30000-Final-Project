using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities
{
    public interface ITeamManager
    {
        IEnumerable<Team> GetAllTeams { get; }

        void AddTeam(Team user);

        void UpdateTeamBid(int id, decimal amount);
    }
}
