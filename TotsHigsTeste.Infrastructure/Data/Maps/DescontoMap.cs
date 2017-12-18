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
    public class DescontoMap : EntityTypeConfiguration<Desconto>
    {
        public DescontoMap()
        {
            ToTable("Desconto");

            Property(x => x.DescontoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasMaxLength(150)
                .IsRequired();

        }
    }
}
