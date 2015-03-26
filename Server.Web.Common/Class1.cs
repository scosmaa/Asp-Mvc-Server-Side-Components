using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages;

namespace RazorTemplatesAndValidationSummary
{
    public static class ValidationSummaryExtensions
    {
        public static HelperResult ModelValidationSummary(this HtmlHelper htmlHelper, Func<string[], HelperResult> tpl)
        {
            ModelState ms;
            htmlHelper.ViewData.ModelState.TryGetValue(htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix, out ms);

            if (ms != null && ms.Errors != null && ms.Errors.Count > 0)
                return tpl(ms.Errors.Select(p => p.ErrorMessage).ToArray());

            return null;
        }

        public static HelperResult ExModelValidationSummary(this HtmlHelper htmlHelper, Func<string[], HelperResult> tpl = null)
        {
            ModelState ms;
            htmlHelper.ViewData.ModelState.TryGetValue(htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix, out ms);

            if (ms != null && ms.Errors != null && ms.Errors.Count > 0)
            {
                var errors = ms.Errors.Select(p => p.ErrorMessage).ToArray();

                if (tpl == null)
                    return App_Code.Templates.ValidationTemplate(errors);

                return tpl(errors);
            }

            return null;
        }
    }
}