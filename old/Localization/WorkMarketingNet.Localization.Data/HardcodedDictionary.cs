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
			{Tuple.Create("WEBSITE_NAME", "en-US"), "WorkMarketingNet"},
			{Tuple.Create("WEBSITE_NAME", "pl-PL"), "WorkMarketingNet"},
									
			{Tuple.Create("Dashboard", "pl-PL"), "Kokpit"},
			{Tuple.Create("Companies", "pl-PL"), "Firmy"},
			{Tuple.Create("Contacts", "pl-PL"), "Kontakty"},
			{Tuple.Create("Books", "pl-PL"), "Książki"},
			{Tuple.Create("Videos", "pl-PL"), "Filmy"},
			{Tuple.Create("Website", "pl-PL"), "Strona"},
			{Tuple.Create("Events", "pl-PL"), "Wydarzenia"},
			{Tuple.Create("Users", "pl-PL"), "Użytkownicy"},
			{Tuple.Create("Quotes", "pl-PL"), "Cytaty"},
			{Tuple.Create("People", "pl-PL"), "Ludzie"},

			{Tuple.Create("Settings", "pl-PL"), "Ustawienia"},
		};

		public string Translate(string text, string culture)
		{
			var key = Tuple.Create(text, culture);
			var translation = _dictionary.ContainsKey(key) ? _dictionary[key] : text;
			return translation;
		}
	}
}
