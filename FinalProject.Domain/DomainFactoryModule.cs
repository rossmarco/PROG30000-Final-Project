using FinalProject.Domain.Entities;
using FinalProject.Domain.Persistence;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain
{
    public class DomainFactoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserRepository>().To<UserRepository>().InSingletonScope();
            Bind<ITeamRepository>().To<TeamRepository>().InSingletonScope();
            Bind<IBetRepository>().To<BetRepository>().InSingletonScope();

            Bind<IUserManager>().To<UserManager>().InSingletonScope();
            Bind<ITeamManager>().To<TeamManager>().InSingletonScope();
            Bind<IBetManager>().To<BetManager>().InSingletonScope();
        }
    }
}
