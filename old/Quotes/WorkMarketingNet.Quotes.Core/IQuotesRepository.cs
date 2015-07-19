using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkMarketingNet.Quotes.Core.Models;

namespace WorkMarketingNet.Quotes.Core
{
    public interface IQuotesRepository
    {
		IEnumerable<Quote> All { get; }
		Quote GetById(Guid id);
		void Add(Quote item);
		bool TryDelete(Guid id);
	}
}
