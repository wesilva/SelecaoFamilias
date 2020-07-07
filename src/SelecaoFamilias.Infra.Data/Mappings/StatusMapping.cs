using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Infra.Data.Extensions;

namespace SelecaoFamilias.Infra.Data.Mappings
{
    public class StatusMapping : EntityTypeConfiguration<Status>
    {
        public override void Map(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");
            
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(s => s.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder.Property(s => s.StatusValido)
               .HasColumnName("StatusValido")
               .IsRequired();

            builder.Ignore(s => s.Valid);
            builder.Ignore(s => s.Invalid);
            builder.Ignore(s => s.Notifications);
        }
    }
}
