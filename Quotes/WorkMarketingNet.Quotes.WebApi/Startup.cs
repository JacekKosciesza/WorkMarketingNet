using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using WorkMarketingNet.Logging.Core;
using WorkMarketingNet.Quotes.Core;
using WorkMarketingNet.Quotes.Data.Repositories;
using WorkMarketingNet.Quotes.Data.EntityFramework;

namespace WorkMarketingNet.Quotes.WebApi
{
    public class Startup
    {
		public Startup(IHostingEnvironment env)
		{
		}

		// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
        {
			services.AddMvc();

			// Dependency Injection
			services.AddSingleton<Logging.Core.ILogger, Logger>();
			services.AddSingleton<IQuotesRepository, Data.EntityFramework.QuotesRepository>();
			services.AddSingleton<QuotesContext>();
		}

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			// Configure the HTTP request pipeline.
			app.UseStaticFiles();

			// Add MVC to the request pipeline.
			app.UseMvc();
		}
    }
}
