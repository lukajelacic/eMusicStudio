using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WebAPI.Database;
using eMuzickiStudio.WebAPI.Filters;
using eMuzickiStudio.WebAPI.Security;
using eMuzickiStudio.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace eMuzickiStudio.WebAPI
{
    
    public class Startup
    {
        public class BasicAuthDocumentFilter : IDocumentFilter
        {
            public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
            {
                var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

                swaggerDoc.Security = new[] { securityRequirements };
            }
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapper();
            services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IKlijentiService, KlijentiService>();
            services.AddScoped<IService<Model.Vrsta, object>, BaseService<Model.Vrsta, object, Database.Vrsta>>();
            services.AddScoped<ICRUDService<Model.MuzickaOprema, MuzickaOpremaSearchRequest,MuzickaOpremaUpsertRequest,MuzickaOpremaUpsertRequest>,MuzickaOpremaService>();
            services.AddScoped<IService<Model.Grad, object>, GradService>();
            services.AddScoped<IRezervacijeService, RezervacijeService>();
            services.AddScoped<IRezervacijeStavkeService, RezervacijaStavkeService>();
            services.AddScoped<ICRUDService<Model.Termini,TerminiSearchRequest,TerminiInsertRequest,TerminiInsertRequest>, TerminiService/*BaseCRUDService<Model.Termini, TerminiSearchRequest, Database.Termini, TerminiInsertRequest, TerminiInsertRequest>*/ >();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Database.Uloge>>();
            //services.AddScoped<ICRUDService<Model.RezervacijeGluveSobe, object, Model.RezervacijeGluveSobe, Model.RezervacijeGluveSobe>, BaseCRUDService<Model.RezervacijeGluveSobe, object, Database.RezervacijeGluveSobe, Model.RezervacijeGluveSobe, Model.RezervacijeGluveSobe>>();
            services.AddScoped<ICRUDService<Model.RezervacijeGluveSobe, RezervacijaGluveSobeSearchRequest, Model.RezervacijeGluveSobe, Model.RezervacijeGluveSobe>, RezervacijaGluveSobeService>();
            services.AddScoped<ICRUDService<Model.Ocjene, object, OcjenaInsertRequest, OcjenaInsertRequest>, BaseCRUDService<Model.Ocjene, object, Database.Ocjene, OcjenaInsertRequest, OcjenaInsertRequest>>();
            services.AddScoped<ISistemPreporuke, SistemPreporukeService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });

            var connection = Configuration.GetConnectionString("eMuzickiStudio");
            services.AddDbContext<_150192V1Context>(x => x.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            app.UseAuthentication();
           // app.UseHttpsRedirection();
            app.UseMvc();
            

        }
    }
}
