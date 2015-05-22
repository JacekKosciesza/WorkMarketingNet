using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;
using WorkMarketingNet.Localization.Core;
using WorkMarketingNet.Localization.Data;
using WorkMarketingNet.Logging.Core;

namespace WorkMarketingNet.Web
{
	public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
			// Add MVC services to the services container.
			services.AddMvc();

			// Dependency Injection
			services.AddSingleton<ILocalizationService, LocalizationService>();
			services.AddSingleton<IGlobalizationService, GlobalizationService>();
			services.AddSingleton<IDictionaryService, HardcodedDictionary>();
			services.AddSingleton<Logging.Core.ILogger, Logger>();
		}

        public void Configure(IApplicationBuilder app)
        {
			// Configure the HTTP request pipeline.			

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
