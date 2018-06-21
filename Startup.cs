using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.EntityFrameworkCore.Extensions;
//using Microsoft.EntityFrameworkCore.Proxies;
using Genealogia.Data;
using Genealogia.Models;
using Genealogia.Services;
using Genealogia.Contracts.Services;

namespace Genealogia
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
            services
                .AddDbContext<ApplicationDbContext>(options =>
                    options
                        .UseMySQL(Configuration.GetConnectionString("DefaultConnection"))
                        //.UseLazyLoadingProxies()
                    );

            services
                .AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services (Dependency injections;)).
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<AreaServiceContract, AreaService>();
            services.AddTransient<PlaceServiceContract, PlaceService>();
            services.AddTransient<DynastyServiceContract, DynastyService>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
            }
            
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
