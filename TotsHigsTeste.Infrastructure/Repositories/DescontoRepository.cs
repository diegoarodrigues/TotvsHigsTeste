using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotvsHigsTeste.Domain;
using TotvsHigsTeste.Domain.Contracts.Repositories;
using TotvsHigsTeste.Infrastructure.Data;

namespace TotvsHigsTeste.Infrastructure.Repositories
{
    public class DescontoRepository : IDescontoRepository
    {
        private AppDataContext _context;

        public DescontoRepository(AppDataContext context)
        {
            this._context = context;
        }

        public Desconto Get(Guid id)
        {
            return _context.Descontos.Where(x => x.DescontoId == id).FirstOrDefault();
        }

        public IList<Desconto> List()
        {
            return _context.Descontos.ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
