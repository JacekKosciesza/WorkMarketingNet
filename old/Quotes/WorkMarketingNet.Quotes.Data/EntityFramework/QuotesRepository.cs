using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkMarketingNet.Quotes.Core;
using WorkMarketingNet.Quotes.Core.Models;

namespace WorkMarketingNet.Quotes.Data.EntityFramework
{
	public class QuotesRepository : IQuotesRepository
	{
		private readonly QuotesContext _db;

		public QuotesRepository(QuotesContext db)
		{
			_db = db;
		}

		public IEnumerable<Quote> All
		{
			get
			{
				return _db.Quotes.Include(q => q.Source);
			}
		}

		public void Add(Quote item)
		{
			throw new NotImplementedException();
		}

		public Quote GetById(Guid id)
		{
			return _db.Quotes.Include(q => q.Source).FirstOrDefault(q => q.Id == id);
		}

		public bool TryDelete(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
