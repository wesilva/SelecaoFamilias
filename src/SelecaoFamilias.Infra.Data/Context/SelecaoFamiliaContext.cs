using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Infra.Data.Extensions;
using SelecaoFamilias.Infra.Data.Mappings;
using SelecaoFamilias.Sorteio.Entities;

namespace SelecaoFamilias.Infra.Data.Context
{
    public class SelecaoFamiliaContext : DbContext
    {
        public DbSet<Familia> Familias { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<FamiliaApta> FamiliasAptas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new PessoaMapping());
            modelBuilder.AddConfiguration(new FamiliaMapping());
            modelBuilder.AddConfiguration(new StatusMapping());
            modelBuilder.AddConfiguration(new FamiliaAptaMapping());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //optionsBuilder.UseSqlServer(config.GetConnectionString("SelecaoFamiliasConnection"));

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SelecaoFamilias;Integrated Security=True");
        }
    }
}
