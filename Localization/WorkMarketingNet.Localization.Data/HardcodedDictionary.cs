using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkMarketingNet.Localization.Core;

namespace WorkMarketingNet.Localization.Data
{
	// TODO: add case sensitivity switch
	public class HardcodedDictionary : IDictionaryService
    {
		private readonly Dictionary<Tuple<string, string>, string> _dictionary = new Dictionary<Tuple<string, string>, string>
		{
			{Tuple.Create("Settings", "pl-PL"), "Ustawienia"},
			{Tuple.Create("Quotes", "pl-PL"), "Cytaty"}
		};

		public string Translate(string text, string culture)
		{
			var key = Tuple.Create(text, culture);
			var translation = _dictionary.ContainsKey(key) ? _dictionary[key] : text;
			return translation;
		}
	}
}
