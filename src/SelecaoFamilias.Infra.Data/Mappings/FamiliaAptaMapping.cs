using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelecaoFamilias.Infra.Data.Extensions;
using SelecaoFamilias.Sorteio.Entities;

namespace SelecaoFamilias.Infra.Data.Mappings
{
    class FamiliaAptaMapping : EntityTypeConfiguration<FamiliaApta>
    {
        public override void Map(EntityTypeBuilder<FamiliaApta> builder)
        {
            builder.ToTable("FamiliaApta");

            builder.OwnsOne(f => f.Id, id =>
            {
                id.Property(f => f.Id)
                .HasColumnName("Id")
                .IsRequired();
            });

            builder.OwnsOne(f => f.FamiliaId, familiaId =>
            {
                familiaId.Property(f => f.Id)
                    .HasColumnName("FamiliaId")
                    .IsRequired();
            });

            builder.Property(f => f.DataSelecao)
               .HasColumnName("DataSelecao")
               .IsRequired();

            builder.OwnsOne(f => f.PontuacaoTotal, pontuacaoTotal =>
            {
                pontuacaoTotal.Property(f => f.Valor)
                    .HasColumnName("Pontuacao")
                    .IsRequired();
            });

            builder.OwnsOne(f => f.CriteriosAtendidos, familiaId =>
            {
                familiaId.Property(f => f.QuantidadeCriteriosAtendidos)
                    .HasColumnName("QuantidadeCriteriosAtendidos")
                    .IsRequired();
            });

            builder.Ignore(s => s.Valid);
            builder.Ignore(s => s.Invalid);
            builder.Ignore(s => s.Notifications);
        }
    }
}
