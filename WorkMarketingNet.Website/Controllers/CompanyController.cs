using Microsoft.AspNet.Mvc;
using WorkMarketingNet.Logging.Core;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkMarketingNet.Website.Controllers
{
    public class CompanyController : Controller
    {
		private readonly ILogger _log;

		public CompanyController(ILogger log)
		{
			_log = log;
		}

		public IActionResult List()
		{
			return View();
		}

		public IActionResult Menu()
		{
			return View();
		}

		public IActionResult Details()
        {
            return View();
        }
    }
}
