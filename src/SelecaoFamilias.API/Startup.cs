using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SelecaoFamilias.Application;
using SelecaoFamilias.Application.Interfaces;
using SelecaoFamilias.Domain.Interfaces.Repository;
using SelecaoFamilias.Infra.Data.Context;
using SelecaoFamilias.Infra.Data.Factories;
using SelecaoFamilias.Infra.Data.Repository;
using SelecaoFamilias.Sorteio.Interfaces;
using SelecaoFamilias.Sorteio.Validators;

namespace SelecaoFamilias.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var connectionString = Configuration.GetConnectionString("SelecaoFamiliaConnectionString");

            services.AddDbContext<SelecaoFamiliaContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<IFamiliaRepository, FamiliaRepository>();
            services.AddScoped<IFamiliaAptaRepository, FamiliaAptaRepository>();
            services.AddScoped<IFamiliaFactory, FamiliaFactory>();
            services.AddScoped<ICalculoDePontosDosCriteriosAppService, CalculoDePontosDosCriteriosAppService>();
            services.AddScoped<IFamiliaAppService, FamiliaAppService>();
            services.AddScoped<IProcessadorCriterios, ProcessadorCriterios>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
