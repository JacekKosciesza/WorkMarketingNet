using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkMarketingNet.Localization.Core
{
    public interface IDictionaryService
    {
		string Translate(string text, string culture);
	}
}
