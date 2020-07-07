using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Infra.Data.Extensions;

namespace SelecaoFamilias.Infra.Data.Mappings
{
    public class PessoaMapping : EntityTypeConfiguration<Pessoa>
    {
        public override void Map(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoas");

            builder.HasNoKey();

            builder.OwnsOne(f => f.Id, id =>
            {
                id.Property(f => f.Id)
                .HasColumnName("Id")
                .IsRequired();
            });

            builder.OwnsOne(p => p.FamiliaId, familiaId => 
            {
                familiaId.Property(p => p.Id)
                    .HasColumnName("FamiliaId")
                    .IsRequired();
            });

            builder.OwnsOne(p => p.Nome, nome =>
            {
                nome.Property(p => p.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(100)")
                    .IsRequired();
            });

            builder.OwnsOne(p => p.Idade, idade =>
            {
                idade.Property(p => p.DataNascimento)
                    .HasColumnName("DataNascimento")
                    .IsRequired();
            });


            builder.OwnsOne(p => p.Renda, renda =>
            {
                renda.Property(p => p.Valor)
                    .HasColumnName("Renda")
                    .IsRequired();
            });

            builder.Property(p => p.Tipo);

            //builder.OwnsOne(p => p.Familia, familia =>
            //{
            //    familia.HasOne(p => p.)
            //        .WithMany(p => p.)
            //});

            //builder.HasOne(p => p.Familia)
            //    .WithMany(p => p.Pessoas)
            //    .HasForeignKey(p => p.FamiliaId);

            builder.Ignore(p => p.Valid);
            builder.Ignore(p => p.Invalid);
            builder.Ignore(p => p.Notifications);
        }
    }
}
