using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotvsHigsTeste.Domain.Contracts.Repositories;
using TotvsHigsTeste.Domain.Contracts.Services;
using TotvsHigsTeste.Startup;
using Unity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            var service = container.Resolve<IProgramaDeDescontoService>();

            var teste = service.GetCpf("000");
        }
    }
}
