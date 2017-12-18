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
    public class ClienteRepository : IClienteRepository
    {
        private AppDataContext _context;

        public ClienteRepository(AppDataContext context)
        {
            this._context = context;
        }

        public IList<Cliente> All()
        {
            return _context.Clientes.ToList();
        }

        public Cliente getCpf(string cpf)
        {
            return _context.Clientes.Where(x => x.Cpf == cpf).FirstOrDefault();
        }

        public void Create(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Update(Cliente programaDeDesconto)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cliente programaDeDesconto)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
