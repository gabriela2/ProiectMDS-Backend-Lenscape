using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ProiectMDS.Contexts;
using ProiectMDS.Repositories.CategorieRepository;
using ProiectMDS.Repositories.ClientRepository;
using ProiectMDS.Repositories.ComandaEchipamentRepository;
using ProiectMDS.Repositories.ComenziRepository;
using ProiectMDS.Repositories.EchipamentCategorieRepository;
using ProiectMDS.Repositories.EchipamentRepository;
using ProiectMDS.Repositories.MagazinEchipamentRepository;
using ProiectMDS.Repositories.MagazinRepository;
using ProiectMDS.Repositories.ProducatorRepository;
using ProiectMDS.Repositories.TipClientRepository;

namespace ProiectMDS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<ICategorieRepository, CategorieRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IComandaEchipamentRepository, ComandaEchipamentRepository>();
            services.AddTransient<IComenziRepository, ComenziRepository>();
            services.AddTransient<IEchipamentCategorieRepository, EchipamentCategorieRepository>();
            services.AddTransient<IEchipamentRepository, EchipamentRepository>();
            services.AddTransient<IMagazinEchipamentRepository, MagazinEchipamentRepository>();
            services.AddTransient<IMagazinRepository, MagazinRepository>();
            services.AddTransient<IProducatorRepository, ProducatorRepository>();
            services.AddTransient<ITipClientRepository, TipClientRepository>();


        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());

            app.UseMvc();
        }
    }
}