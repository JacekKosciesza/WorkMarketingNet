using Microsoft.AspNet.Mvc.Razor;
using Microsoft.AspNet.Mvc.Razor.OptionDescriptors;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WorkMarketingNet.Localization.Core;

namespace WorkMarketingNet.Web.Localization
{
	public class LocalizedRazorViewEngine : RazorViewEngine
	{
		IGlobalizationService _globalizationService;

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
						string.Format("~/Views/{{1}}/{0}/{{0}}.cshtml", culture),
						string.Format("~/Views/{{1}}/{{0}}.{0}.cshtml", culture),
						string.Format("~/Views/Shared/{0}/{{0}}.cshtml", culture),
						string.Format("~/Views/Shared/{{0}}.{0}.cshtml", culture),
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
				List<string> existing = base.AreaViewLocationFormats.ToList();
				existing.InsertRange(0,
					new List<string>
					{
						string.Format("~/Areas/{{2}}/Views/{{1}}/{0}/{{0}}.cshtml", culture),
                        string.Format("~/Areas/{{2}}/Views/{{1}}/{{0}}.{0}.cshtml", culture),
                        string.Format("~/Areas/{{2}}/Views/Shared/{0}/{{0}}.cshtml", culture),
                        string.Format("~/Areas/{{2}}/Views/Shared/{{0}}.{0}.cshtml", culture),
                    }
				);

				return existing;
			}
		}
	}
}
