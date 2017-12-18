using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotvsHigsTeste.Business.Services;
using TotvsHigsTeste.Domain.Contracts.Repositories;
using TotvsHigsTeste.Domain.Contracts.Services;
using TotvsHigsTeste.Infrastructure.Data;
using TotvsHigsTeste.Infrastructure.Repositories;
using Unity.Lifetime;
using Microsoft.Practices.Unity;
using Unity;

namespace TotvsHigsTeste.Startup
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IProgramaDeDescontoRepository, ProgramaDeDescontoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IProgramaDeDescontoService, ProgramaDeDescontoService>(new HierarchicalLifetimeManager());
            container.RegisterType<IDescontoRepository, DescontoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IClienteRepository, ClienteRepository>(new HierarchicalLifetimeManager());
        }
    }
}
