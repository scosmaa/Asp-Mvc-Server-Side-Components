using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace Common
{
    public static class CustomComponents
    {
        public static HelperResult Component1(ExternalComponentUser user, Func<ExternalComponentUser, HelperResult> tpl = null)
        {
            if (tpl == null)
            {
                return CustomTemplates.Views.Component1(user);
            }
            return tpl(user);
        }
    }
}