using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;

namespace WorkMarketingNet.Web
{
	public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
			// Add MVC services to the services container.
			services.AddMvc();
		}

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerfactory)
        {
			// Configure the HTTP request pipeline.

			// Add the console logger.
			loggerfactory.AddConsole(minLevel: LogLevel.Warning);

			// Add static files to the request pipeline.
			app.UseStaticFiles();

			// Add MVC to the request pipeline.
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller}/{action}/{id?}",
					defaults: new { controller = "Home", action = "Index" });
			});
		}
    }
}
