using FinalProject.Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities
{
    public class UserManager : IUserManager
    {
        private IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAllUsers
        {
            get
            {
                return _userRepository.UserTable;
            }
        }

        public void AddUser(User user)
        {
            _userRepository.CreateUser(user);
        }
    }
}
