using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Infra.Data.Extensions;

namespace SelecaoFamilias.Infra.Data.Mappings
{
    public class FamiliaMapping : EntityTypeConfiguration<Familia>
    {
        public override void Map(EntityTypeBuilder<Familia> builder)
        {
            builder.ToTable("Familias");

            builder.HasNoKey();

            builder.OwnsOne(f => f.Id, id =>
            {
                id.Property(f => f.Id)
                .HasColumnName("Id")
                .IsRequired();
            });

            builder.OwnsOne(f => f.StatusId, statusId =>
            {
                statusId.Property(f => f.Id)
                .HasColumnName("StatusId")
                .IsRequired();
            });

            //builder.HasOne(f => f.Status)
            //    .WithMany(f => f.Familias)
            //    .HasForeignKey(f => f.StatusId)
            //    .IsRequired();

            builder.Ignore(f => f.Valid);
            builder.Ignore(f => f.Invalid);
            builder.Ignore(f => f.Notifications);
        }
    }
}
