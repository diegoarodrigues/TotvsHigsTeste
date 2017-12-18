using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotvsHigsTeste.Domain;
using TotvsHigsTeste.Domain.Contracts.Repositories;
using TotvsHigsTeste.Domain.Contracts.Services;

namespace TotvsHigsTeste.Business.Services
{
    public class ProgramaDeDescontoService : IProgramaDeDescontoService
    {
        private IProgramaDeDescontoRepository _repository;
        private IDescontoRepository _repositoryDesconto;
        private IClienteRepository _repositoryCliente;

        public ProgramaDeDescontoService(IProgramaDeDescontoRepository repository, IDescontoRepository repositoryDesconto, IClienteRepository repositoryCliente)
        {
            _repository = repository;
            _repositoryDesconto = repositoryDesconto;
            _repositoryCliente = repositoryCliente;
        }

        public ProgramaDeDesconto GetCpf(string cpf)
        {
            return _repository.Get(cpf);
        }

        public IList<Desconto> ListDesconto()
        {
            return _repositoryDesconto.List();
        }

        public void Add(int codigoConsultor, string nomeCliente, string cpfCliente, string descontoId)
        {
            
            var cliente = _repositoryCliente.getCpf(cpfCliente);
            if (cliente == null)
            {
                _repositoryCliente.Create(new Cliente(nomeCliente, cpfCliente));
            }
            cliente = _repositoryCliente.getCpf(cpfCliente);

            var programDesconto = new ProgramaDeDesconto(codigoConsultor);
            programDesconto.Cliente = cliente;
            Guid guid = new Guid(descontoId);
            programDesconto.Desconto = _repositoryDesconto.Get(guid);
            
            _repository.Create(programDesconto);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

    }
}
