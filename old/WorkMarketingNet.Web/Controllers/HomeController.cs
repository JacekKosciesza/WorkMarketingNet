using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WorkMarketingNet.Logging.Core;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkMarketingNet.Web.Controllers
{
    public class HomeController : Controller
    {
		private readonly ILogger _log;

		public HomeController(ILogger log)
		{
			_log = log;
		}

        // GET: /<controller>/
        public IActionResult Index()
        {
			_log.Debug("Home/Index");
            return View();
        }
    }
}
