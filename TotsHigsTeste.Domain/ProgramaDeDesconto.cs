using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotvsHigsTeste.Domain
{
    public class ProgramaDeDesconto
    {
        protected ProgramaDeDesconto() { }

        public ProgramaDeDesconto(int codigoConsultor) {
            this.CodigoConsultor = codigoConsultor;
        }

        public Guid ProgramaDeDescontoId { get; set; }
        public int CodigoConsultor { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Desconto Desconto { get; set; }

    }
}
