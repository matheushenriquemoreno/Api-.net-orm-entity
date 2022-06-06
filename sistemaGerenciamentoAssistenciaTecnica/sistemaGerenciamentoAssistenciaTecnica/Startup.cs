using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using sistemaGerenciamentoAssistenciaTecnica.InfraEntity;
using sistemaGerenciamentoAssistenciaTecnica.Model;
using sistemaGerenciamentoAssistenciaTecnica.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace sistemaGerenciamentoAssistenciaTecnica
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

            services.AddDbContext<AppDBContext>(Opts => Opts.UseLazyLoadingProxies().UseMySQL(Configuration.GetConnectionString("FilmeConecction")));

            services.AddTransient<IRepositoryBase<Tecnico>, RepositoryBase<Tecnico>>();
            services.AddTransient<IRepositoryBase<Especialidades>, RepositoryBase<Especialidades>>();
            services.AddTransient<IRepositoryBase<Cliente>, RepositoryBase<Cliente>>();
            services.AddTransient<IRepositoryBase<EquipamentoCliente>, RepositoryBase<EquipamentoCliente>>();
            services.AddTransient<IRepositoryBase<OrdemServico>, RepositoryBase<OrdemServico>>();
            services.AddTransient<IRepositoryBase<Pagamento>, RepositoryBase<Pagamento>>();
            services.AddTransient<IRepositoryBase<StatusOrdemServico>, RepositoryBase<StatusOrdemServico>>();
            services.AddTransient<IRepositoryBase<StatusPagamento>, RepositoryBase<StatusPagamento>>();
            services.AddTransient<IRepositoryBase<Equipamento>, RepositoryBase<Equipamento>>();


            services.AddControllers().AddNewtonsoftJson(x =>
                    x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "sistemaGerenciamentoAssistenciaTecnica", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "sistemaGerenciamentoAssistenciaTecnica v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
