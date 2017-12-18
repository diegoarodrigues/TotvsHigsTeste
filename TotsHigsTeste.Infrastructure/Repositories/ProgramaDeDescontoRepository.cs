using TotvsHigsTeste.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotvsHigsTeste.Domain;
using TotvsHigsTeste.Infrastructure.Data;

namespace TotvsHigsTeste.Infrastructure.Repositories
{
    public class ProgramaDeDescontoRepository : IProgramaDeDescontoRepository
    {

        private AppDataContext _context;

        public ProgramaDeDescontoRepository(AppDataContext context)
        {
            this._context = context;
        }

        public ProgramaDeDesconto Get(string cpf)
        {
            return _context.ProgramaDeDescontos.Where(x => x.Cliente.Cpf.ToLower() == cpf.ToLower()).FirstOrDefault();
        }

        //public ProgramaDeDesconto Get(Guid id)
        //{
        //    return _context.ProgramaDeDescontos.Where(x => x.ProgramaDeDescontoId == id).FirstOrDefault();
        //}

        public void Create(ProgramaDeDesconto programaDeDesconto)
        {
            _context.ProgramaDeDescontos.Add(programaDeDesconto);
            _context.SaveChanges();
        }

        public void Update(ProgramaDeDesconto programaDeDesconto)
        {
            //_context.Entry<User>(user).State = System.Data.Entity.EntityState.Modified;
            //_context.SaveChanges();
        }

        public void Delete(ProgramaDeDesconto programaDeDesconto)
        {
            //_context.Users.Remove(user);
            //_context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
