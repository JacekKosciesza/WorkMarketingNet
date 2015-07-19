using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkMarketingNet.Quotes.Core.Models;

namespace WorkMarketingNet.Quotes.Data.EntityFramework
{
    public class QuotesContext : DbContext
	{
		public QuotesContext()
		{
   		}

		public DbSet<Quote> Quotes { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Visual Studio 2015 | Use the LocalDb 12 instance created by Visual Studio
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WorkMarketingNet;Trusted_Connection=True;");			
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			//builder.Entity<Quote>().Key(v => v.Id);

			base.OnModelCreating(builder);
		}
	}
}
