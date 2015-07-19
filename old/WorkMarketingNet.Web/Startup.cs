using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;
using WorkMarketingNet.Localization.Core;
using WorkMarketingNet.Localization.Data;
using WorkMarketingNet.Logging.Core;
using WorkMarketingNet.Quotes.Core;
using WorkMarketingNet.Quotes.Data.EntityFramework;
using WorkMarketingNet.Quotes.Data.Repositories;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Razor;
using System;
using WorkMarketingNet.Web.Localization;

namespace WorkMarketingNet.Web
{
	public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
			// Add MVC services to the services container.
            services.AddMvc().Configure<MvcOptions>(options =>
			{
				options.ViewEngines.Clear();
				options.ViewEngines.Add(typeof(LocalizedRazorViewEngine));
				//options.ViewEngines.Add(typeof(RazorViewEngine));
			});

			// Dependency Injection
			//services.AddScoped<IRazorPageFactory, LocalizedVirtualPathRazorPageFactory>();
			services.AddSingleton<ILocalizationService, LocalizationService>();
			services.AddSingleton<IGlobalizationService, GlobalizationService>();
			services.AddSingleton<IDictionaryService, HardcodedDictionary>();
			services.AddSingleton<Logging.Core.ILogger, Logger>();
			services.AddSingleton<IQuotesRepository, Quotes.Data.EntityFramework.QuotesRepository>();
			services.AddSingleton<QuotesContext>();
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
