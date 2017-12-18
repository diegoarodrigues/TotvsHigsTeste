using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotvsHigsTeste.Domain.Contracts.Repositories
{
    public interface IClienteRepository : IDisposable
    {
        IList<Cliente> All();
        void Create(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(Cliente cliente);
        Cliente getCpf(string cpf);
    }
}
