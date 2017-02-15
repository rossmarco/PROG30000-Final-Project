using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities
{
    public interface IUserManager
    {
        IEnumerable<User> GetAllUsers { get; }

        void AddUser(User user);
    }
}
