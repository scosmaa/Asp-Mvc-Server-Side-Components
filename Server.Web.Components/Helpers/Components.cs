using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace Server.Web.Components.Helpers
{
    public class Components
    {
        public static MvcHtmlString MvcHtmlString()
        {
            TagBuilder tag = new TagBuilder("strong");
            tag.InnerHtml = "<i>I've used an Mvc Html String!!</i>";
            return new MvcHtmlString(tag.ToString());
        }


        public static HelperResult Helper()
        {
            return new HelperResult
            (
                writer =>
                {
                    writer.Write("<i>I've used an Helper Result Writer!!</i>");
                }
            );
        }
    }
}