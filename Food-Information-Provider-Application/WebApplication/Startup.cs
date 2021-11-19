using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using CustomVisionService.Predictions;
using DataAccessDapper.DataAccess;
using Microsoft.Extensions.Configuration;

namespace WebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; private set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddSession();
            services.AddScoped<IPredictionService>(sp => new PredictionService(
                predictionEndpoint: Configuration["CustomVision:Endpoint"],
                projectId: Configuration["CustomVision:ProjectID"],
                publishedProjectName: Configuration["CustomVision:ProjectName"],
                predictionKey: Configuration["CustomVision:Key"]
                ));
            services.AddScoped<IProductConnection>(sp => new ProductConnection(Configuration.GetConnectionString("Testing")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            } else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
