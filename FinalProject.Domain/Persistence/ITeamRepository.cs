using FinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Persistence
{
    public interface ITeamRepository
    {
        IEnumerable<Team> TeamTable { get; }

        void CreateTeam(Team team);

        void UpdateTeamBidInfo(Team team, decimal amount);
    }
}
