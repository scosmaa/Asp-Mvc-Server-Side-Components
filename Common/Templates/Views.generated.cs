﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomTemplates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public static class Views
    {

public static System.Web.WebPages.HelperResult Component1(Common.Model.ExternalComponentUser user)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 4 "..\..\Templates\Views.cshtml"
 

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    <span>Hi! I\'m ");



#line 5 "..\..\Templates\Views.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, user.Name);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, " ");



#line 5 "..\..\Templates\Views.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, user.Surname);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, " and I came from an <strong>external</strong> component!</span>\r\n");



#line 6 "..\..\Templates\Views.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult Component2(Common.Model.ExternalComponentUser user)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 9 "..\..\Templates\Views.cshtml"
 

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    <span>Hi! I\'m ");



#line 10 "..\..\Templates\Views.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, user.Name);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, " ");



#line 10 "..\..\Templates\Views.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, user.Surname);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, " and I came from an <strong>external</strong> component! (2)</span>\r\n");



#line 11 "..\..\Templates\Views.cshtml"

#line default
#line hidden

});

}


    }
}
#pragma warning restore 1591