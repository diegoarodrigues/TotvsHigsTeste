using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotvsHigsTeste.Domain;

namespace TotvsHigsTeste.Infrastructure.Data.Maps
{
    public class ProgramaDeDescontoMap : EntityTypeConfiguration<ProgramaDeDesconto>
    {
        public ProgramaDeDescontoMap()
        { 
        ToTable("ProgramaDeDesconto");

            Property(x => x.ProgramaDeDescontoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CodigoConsultor)
                .IsRequired();

            HasRequired(x => x.Cliente);
            HasRequired(x => x.Desconto);
        }
    }
}
