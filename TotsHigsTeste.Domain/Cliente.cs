using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotvsHigsTeste.Domain
{
    public class Cliente
    {
        protected Cliente() { }

        public Cliente(string nome, string cpf) {
            this.Nome = nome;
            this.Cpf = cpf;
        }

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
