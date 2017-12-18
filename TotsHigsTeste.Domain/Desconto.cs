using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotvsHigsTeste.Domain
{
    public class Desconto
    {
        protected Desconto() { }
        public Desconto(string id) {
            this.DescontoId = new Guid(id);
        }

        public Guid DescontoId { get; set; }
        public string Nome { get; set; }
    }
}
