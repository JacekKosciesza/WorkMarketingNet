using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkMarketingNet.Localization.Core
{
    public class GlobalizationService : IGlobalizationService
    {
		public string Culture
		{
			get
			{
				return "pl-PL"; // CultureInfo.CurrentCulture.ToString();
			}
		}
	}
}
