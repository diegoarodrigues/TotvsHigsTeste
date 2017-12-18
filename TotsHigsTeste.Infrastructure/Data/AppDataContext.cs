using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TotvsHigsTeste.Domain;
using TotvsHigsTeste.Infrastructure.Data.Maps;

namespace TotvsHigsTeste.Infrastructure.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base("AppConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<ProgramaDeDesconto> ProgramaDeDescontos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Desconto> Descontos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProgramaDeDescontoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new DescontoMap());
        }
    }
}
