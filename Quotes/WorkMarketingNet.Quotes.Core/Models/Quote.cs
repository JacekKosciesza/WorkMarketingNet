using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkMarketingNet.Quotes.Core.Models
{
    public class Quote
    {
		public Guid Id { get; set; }
		public string Slug { get; set; }
		public string Body { get; set; }
		public Source Source { get; set; }
	}
}
