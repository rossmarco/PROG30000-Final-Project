using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Domain.Entities;

namespace FinalProject.Domain.Persistence
{
    public class UserRepository : IUserRepository
    {
        private FinalProjectDbContext _dbContext;

        public UserRepository()
        {
            _dbContext = new FinalProjectDbContext();
        }

        public IEnumerable<User> UserTable
        {
            get
            {
                return _dbContext.User;
            }
        }

        public void CreateUser(User user)
        {
            if (user.UserId == 0)
            {
                _dbContext.User.Add(user);
            }

            _dbContext.SaveChanges();
        }
    }
}
