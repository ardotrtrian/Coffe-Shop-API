using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShopAPI.BLL;
using CoffeShopAPI.DAL;
using CoffeShopAPI.DAL.Interfaces;
using CoffeShopAPI.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CoffeShopAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var dbContextOptionsBuilder = new DbContextOptionsBuilder<EspressoDbContext>();

            dbContextOptionsBuilder.UseSqlServer(Configuration["ConnectionString:DefaultConnection"]);

            services.AddSingleton(provider => new EspressoDbContext(dbContextOptionsBuilder.Options));

            services.AddSingleton<IMenu, MenuDAL>();
            services.AddSingleton<MenuBLL>();

            services.AddSingleton<IReservation, ReservationDal>();
            services.AddSingleton<ReservationBLL>();
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
