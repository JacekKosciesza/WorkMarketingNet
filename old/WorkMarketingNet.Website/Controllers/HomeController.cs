using Microsoft.AspNet.Mvc;
using WorkMarketingNet.Logging.Core;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkMarketingNet.Website.Controllers
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
