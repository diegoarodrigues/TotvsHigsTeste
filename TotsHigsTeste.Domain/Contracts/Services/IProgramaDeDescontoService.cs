using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotvsHigsTeste.Domain.Contracts.Services
{
    public interface IProgramaDeDescontoService : IDisposable
    {
        ProgramaDeDesconto GetCpf(string cpf);
        IList<Desconto> ListDesconto();
        void Add(int codigoConsultor, string nomeCliente, string cpfCliente, string descontoId);
    }
}
