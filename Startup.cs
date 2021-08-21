using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RRHH.Data;

namespace RRHH
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //Autenticacion para IIS y IIS Express
            //services.AddAuthentication(IISDefaults.AuthenticationScheme);
            //.AddNegotiate();

            //Autenticacion para Kestrel, IIS y IIS Express, funciona para todos
            services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
            .AddNegotiate();

            
            services.AddDbContext<RRHHContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("RRHHContext"),
                    sqlServerOptions => sqlServerOptions.CommandTimeout(60)));

            services.AddDbContext<ContabContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ContabContext")));

            services.AddAuthorization(options =>
            {

                //Ejemplo con varios grupos de usuarios
                //options.AddPolicy("ElevatedRights", policy =>
                //  policy.RequireRole("Administrator", "PowerUser", "BackupAdministrator"));

                //APP_CUBITOS_INTERFAZ_RH_PRO->Ambiente productivo
                //APP_CUBITOS_INTERFAZ_RH_PRU->Ambiente de pruebas
                //APP_ADMINCUBITOS_INTERFAZ_RH_PRO->Ambiente productivo
                //APP_ADMINCUBITOS_INTERFAZ_RH_PRU->Ambiente de pruebas(Ovidio)

                options.AddPolicy("CubitosUsers",
                policy => policy.RequireRole(@"CAJADEAHORROS\APP_CUBITOS_INTERFAZ_RH_PRU", @"CAJADEAHORROS\APP_ADMINCUBITOS_INTERFAZ_RH_PRU"));

                options.AddPolicy("CubitosAdmin",
                policy => policy.RequireRole(@"CAJADEAHORROS\APP_ADMINCUBITOS_INTERFAZ_RH_PRU"));

            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            //Se utiliza para la autorizacion por Roles y Claims
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
