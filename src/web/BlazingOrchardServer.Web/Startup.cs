using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlazingOrchardServer.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOrchardCms();
            
            services.AddCors(
                options => options.AddDefaultPolicy(
                    policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) 
                app.UseDeveloperExceptionPage();

            app.UseCors();
            app.UseStaticFiles();
            app.UseOrchardCore();
        }
    }
}