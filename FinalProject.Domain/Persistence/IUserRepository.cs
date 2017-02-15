using FinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Persistence
{
    public interface IUserRepository
    {
        IEnumerable<User> UserTable { get; }

        void CreateUser(User user);
    }
}
