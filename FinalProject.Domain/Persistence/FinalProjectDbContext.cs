using FinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Persistence
{
    public class FinalProjectDbContext : DbContext
    {
        public FinalProjectDbContext() : base("LocalDB")
        {
        }

        public DbSet<User> User { get; set; }
        
        public DbSet<Team> Team { get; set; }

        public DbSet<Bet> Bet { get; set; }
    }
}
