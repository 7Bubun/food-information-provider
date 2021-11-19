using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomVisionService.Predictions;
using DataAccessDapper.DataAccess;

namespace WebApplication
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddSession();
            services.AddScoped<IPredictionService>(sp => new PredictionService(
                predictionEndpoint: "https://westeurope.api.cognitive.microsoft.com",
                projectId: "38b15e02-55cc-4459-9586-b82f938ff613",
                publishedProjectName: "TestingPurpose",
                predictionKey: "0e9026388d194eb9a961869302df5bf9"
                ));
            services.AddScoped<IProductConnection>(sp => new ProductConnection());
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
