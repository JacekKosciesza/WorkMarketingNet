using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkMarketingNet.Localization.Core
{
    public interface ILocalizationService
    {
		string Translate(string text, params object[] args);
	}
}
