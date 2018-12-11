using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using HackFest.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HackFest
{
    public class Startup
    {

        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //var connexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Loik\\Documents\\HackfestDataBase.mdf;Integrated Security=True;Connect Timeout=30";
            services.AddDbContext<ContextBD>
                (options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            #region Localisation      
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc()
              .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);
            #endregion


            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
            services.AddTransient<IDepot, DepotBD>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //app.UseStatusCodePages();
            //app.UseDeveloperExceptionPage();
            //app.UseSession();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            // on détermine les 2 cultures que nous allons utiliser
            var supportedCultures = new[]
            {
                new CultureInfo("fr-CA"),
                new CultureInfo("en-US"),
            };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("fr-CA"),
                SupportedCultures = supportedCultures,//Ce qui affiche les signes de $ , l<affichage de la date..
                SupportedUICultures = supportedCultures //Ce qui fait les traductions
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute("A", "{action}", defaults: new { controller = "Home" });
                routes.MapRoute("B", "{controller}/{action}", defaults: new { controller = "Home" });
                routes.MapRoute("C", "", defaults: new { controller = "Home", action = "Index" }); // cas particulier de la page index qui donne un call à /
            });
        }
    }
}
