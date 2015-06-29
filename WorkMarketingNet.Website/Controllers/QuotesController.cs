using Microsoft.AspNet.Mvc;
using WorkMarketingNet.Logging.Core;
using WorkMarketingNet.Quotes.Core;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkMarketingNet.Website.Controllers
{
    public class QuotesController : Controller
    {
		private readonly IQuotesRepository _repository;
		private readonly ILogger _log;
		
		public QuotesController(IQuotesRepository repository, ILogger log)
		{
			_repository = repository;
            _log = log;
		}

		// GET: /<controller>/
		public IActionResult List()
        {
			var model = _repository.All;
            return View(model);
        }
    }
}
