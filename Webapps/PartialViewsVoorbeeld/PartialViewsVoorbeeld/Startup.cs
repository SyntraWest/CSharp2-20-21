using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewsVoorbeeld
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
            // TIP: Razor Pages en MVC tegelijk gebruiken in een app:
            services.AddControllersWithViews(); // EERST MVC
            services.AddRazorPages(); // DAN Pages

            services.AddSingleton(sp => new Models.VoorbeeldModel
            {
                Titel = "Dit is een voorbeeldmodel",
                Submodellen = new List<Models.VoorbeeldSubmodel>
                {
                    new Models.VoorbeeldSubmodel
                    {
                        Datum = DateTime.Now.AddDays(-1),
                        Tekst = "Gisteren",
                        Getal = 24,
                    },
                    new Models.VoorbeeldSubmodel
                    {
                        Datum = DateTime.Now.AddHours(-1),
                        Tekst = "Een uur geleden",
                        Getal = 1820,
                    },
                    new Models.VoorbeeldSubmodel
                    {
                        Datum = DateTime.Now.AddMinutes(-1),
                        Tekst = "Een minuut geleden",
                        Getal = 241,
                    },
                    new Models.VoorbeeldSubmodel
                    {
                        Datum = DateTime.Now,
                        Tekst = "Nu",
                        Getal = 24222,
                    },
                }
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute( // Eerst MVC
                    name: "default",
                    pattern: "{controller=Voorbeeld}/{action=Index}/{id?}");
                endpoints.MapRazorPages(); // Dan Razor Pages
            });

        }
    }
}
