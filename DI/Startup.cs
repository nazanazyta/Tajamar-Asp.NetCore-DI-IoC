using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.Data;
using DI.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace DI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            String cadenasql =
                "Data Source=localhost;Initial Catalog=PRUEBAS;User ID=sa;Password=MCSD2020";
            services.AddDbContext<PruebasContext>
                (options => options.UseSqlServer(cadenasql));
            services.AddTransient<IRepository, RepositorySql>();
            //String cadenamysql =
            //    "server=localhost;database=pruebas;user id=root;password=admin;";
            //services.AddDbContextPool<PruebasContext>
            //    (options => options.UseMySql(cadenamysql, ServerVersion.AutoDetect(cadenamysql)));
            //services.AddTransient<IRepository, RepositoryMySql>();
            //services.AddTransient<IRepository, RepositoryXML>();
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}