using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkMarketingNet.Quotes.Core.Models;

namespace WorkMarketingNet.Quotes.OData
{
    public interface IODataContext
    {
		IEnumerable<Quote> Quotes { get; }
	}
}
