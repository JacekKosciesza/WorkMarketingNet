using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkMarketingNet.Localization.Core
{
	public class LocalizationService : ILocalizationService
	{
		private readonly IGlobalizationService _globalization;
		private readonly IDictionaryService _dictionary;
		public LocalizationService(IGlobalizationService globalization, IDictionaryService dictionary)
		{
			_globalization = globalization;
			_dictionary = dictionary;
		}

		public string Translate(string text, params object[] args)
		{
			var culture = _globalization.Culture;
			var translation = _dictionary.Translate(text, culture);
			var formatted = (args == null || args.Length == 0) ? translation : string.Format(translation, args);

			return formatted;
		}
	}
}
