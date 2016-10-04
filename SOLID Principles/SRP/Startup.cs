using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SRP.Core;

namespace SRP
{
    public class Startup
    {
        public IConfigurationRoot Configuration { set; get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                                .SetBasePath(env.ContentRootPath)
                                .AddJsonFile("appsettings.json", reloadOnChange: true, optional: false)
                                .AddJsonFile($"appsettings.{env}.json", optional: true);
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(ServiceLifetime.Scoped);
            services.AddScoped<CustomerSearch>();
            services.AddSingleton(provider => Configuration);
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, 
                              IHostingEnvironment env, 
                              ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDatabaseErrorPage();
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
