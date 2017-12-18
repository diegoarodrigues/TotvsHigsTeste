using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TotvsHigsTeste.Api.Models
{
    public class ProGramaDeDescontoModel
    {
        public int CodigoConsultor { get; set; }
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public string DescontoId { get; set; }
    }
}