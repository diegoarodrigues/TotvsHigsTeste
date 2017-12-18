using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotvsHigsTeste.Domain.Contracts.Repositories
{
    public interface IProgramaDeDescontoRepository : IDisposable
    {
        ProgramaDeDesconto Get(string cpf);
        //ProgramaDeDesconto Get(Guid id);
        void Create(ProgramaDeDesconto programaDeDesconto);
        void Update(ProgramaDeDesconto programaDeDesconto);
        void Delete(ProgramaDeDesconto programaDeDesconto);
    }
}
