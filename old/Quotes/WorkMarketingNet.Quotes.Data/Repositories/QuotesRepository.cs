using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkMarketingNet.Quotes.Core;
using WorkMarketingNet.Quotes.Core.Models;

namespace WorkMarketingNet.Quotes.Data.Repositories
{
    public class QuotesRepository : IQuotesRepository
	{
		readonly List<Quote> _quotes = new List<Quote>
		{
			new Quote { Id = Guid.NewGuid() , Slug = "don-t-wait", Body = "Don’t wait! The time will never be just right!", Source = new Source { Name = "Napoleon Hill", Image = "http://dummyimage.com/128x128/000/fff" } }
		};

		public IEnumerable<Quote> All
		{
			get
			{
				return _quotes;
			}
		}

		public Quote GetById(Guid id)
		{
			return _quotes.FirstOrDefault(x => x.Id == id);
		}

		public void Add(Quote item)
		{
			item.Id = Guid.NewGuid();
			_quotes.Add(item);
		}

		public bool TryDelete(Guid id)
		{
			var item = GetById(id);
			if (item == null)
			{
				return false;
			}
			_quotes.Remove(item);
			return true;
		}
	}
}
