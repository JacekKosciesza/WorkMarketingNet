using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WorkMarketingNet.Quotes.Core;
using WorkMarketingNet.Logging.Core;
using WorkMarketingNet.Quotes.Core.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkMarketingNet.Quotes.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
		private readonly IQuotesRepository _repository;
		private readonly ILogger _log;

		public QuotesController(IQuotesRepository repository, ILogger log)
		{
			_repository = repository;
			_log = log;
		}

		[HttpGet]
        public IEnumerable<Quote> Get()
        {
			return _repository.All;
        }

		[HttpGet("{id:guid}", Name = "GetByIdRoute")]
		public IActionResult Get(Guid id)
        {
			var item = _repository.GetById(id);
			if (item == null)
			{
				return HttpNotFound();
			}

			return new ObjectResult(item);
		}

        [HttpPost]
        public void Post([FromBody]Quote quote)
        {
			if (!ModelState.IsValid)
			{
				Context.Response.StatusCode = 400;
			}
			else
			{
				_repository.Add(quote);

				string url = Url.RouteUrl("GetByIdRoute", new { id = quote.Id }, Request.Scheme, Request.Host.ToUriComponent());
				Context.Response.StatusCode = 201;
				Context.Response.Headers["Location"] = url;
			}
		}

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Quote quote)
        {
			// TODO
        }

		[HttpDelete("{id}")]
		public IActionResult Delete(Guid id)
        {
			if (_repository.TryDelete(id))
			{
				return new HttpStatusCodeResult(204); // 201 No Content
			}
			else
			{
				return HttpNotFound();
			}
		}
    }
}
