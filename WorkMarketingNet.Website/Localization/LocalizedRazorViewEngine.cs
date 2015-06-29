using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc.Razor;
using Microsoft.AspNet.Mvc.Razor.OptionDescriptors;
using WorkMarketingNet.Localization.Core;

namespace WorkMarketingNet.Website.Localization
{
	public class LocalizedRazorViewEngine : RazorViewEngine
	{
		readonly IGlobalizationService _globalizationService;

		public LocalizedRazorViewEngine(IRazorPageFactory pageFactory, IRazorViewFactory razorViewFactory, IViewLocationExpanderProvider viewLocationExpanderProvider, IViewLocationCache viewLocationCache, IGlobalizationService globalizationService)
			: base(pageFactory, razorViewFactory, viewLocationExpanderProvider, viewLocationCache)
		{
			_globalizationService = globalizationService;
        }

		public override IEnumerable<string> ViewLocationFormats
		{
			get
			{
				var culture = _globalizationService.Culture;
                var existing = base.ViewLocationFormats.ToList();

				existing.InsertRange(0,
					new List<string>
					{
						$"~/Views/{{1}}/{culture}/{{0}}.cshtml",
						$"~/Views/{{1}}/{{0}}.{culture}.cshtml",
						$"~/Views/Shared/{culture}/{{0}}.cshtml",
						$"~/Views/Shared/{{0}}.{culture}.cshtml",
					}
				);

				return existing;
			}
		}

		public override IEnumerable<string> AreaViewLocationFormats
		{
			get
			{
				var culture = _globalizationService.Culture;
				var existing = base.AreaViewLocationFormats.ToList();
				existing.InsertRange(0,
					new List<string>
					{
						$"~/Areas/{{2}}/Views/{{1}}/{culture}/{{0}}.cshtml",
						$"~/Areas/{{2}}/Views/{{1}}/{{0}}.{culture}.cshtml",
						$"~/Areas/{{2}}/Views/Shared/{culture}/{{0}}.cshtml",
						$"~/Areas/{{2}}/Views/Shared/{{0}}.{culture}.cshtml",
                    }
				);

				return existing;
			}
		}
	}
}
