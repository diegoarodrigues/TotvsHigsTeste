using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotvsHigsTeste.Domain;

namespace TotvsHigsTeste.Domain.Contracts.Repositories
{
    public interface IDescontoRepository : IDisposable
    {
        IList<Desconto> List();
        Desconto Get(Guid id);
    }
}
