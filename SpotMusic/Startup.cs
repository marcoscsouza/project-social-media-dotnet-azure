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
using Microsoft.EntityFrameworkCore;
using SpotMusic.Data;
using SpotMusic.Areas.Identity.Data;
using Data;
using Domain.Interfaces.Repositories;
using Data.Repositories;

namespace SpotMusic
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
            services.AddControllersWithViews();

            services.AddDbContext<SpotMusicContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("SpotMusicContext")));

            services.AddScoped<IMusicoRepository, MusicoRepository>();
            services.AddScoped<ISpotRepository, SpotRepository>();

            services.AddDbContext<IdentityDBContext>(options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("IdentityDBContextConnection")));

            services.AddHttpClient("", client => {
                client.BaseAddress = new Uri(Configuration["BaseUrlApi"]);
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
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Spot}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
