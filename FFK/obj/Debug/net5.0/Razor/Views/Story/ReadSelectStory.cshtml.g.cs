#pragma checksum "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Story\ReadSelectStory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8450cda1a07d4b3981a8b3e31842aaa7e0516b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Story_ReadSelectStory), @"mvc.1.0.view", @"/Views/Story/ReadSelectStory.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\_ViewImports.cshtml"
using FFK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Story\ReadSelectStory.cshtml"
using FFK.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8450cda1a07d4b3981a8b3e31842aaa7e0516b9e", @"/Views/Story/ReadSelectStory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0256a96dce335abdd5e5bc98b9094ab4b9cb50a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Story_ReadSelectStory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FFK.ViewModels.ReadStoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Story\ReadSelectStory.cshtml"
  
    ViewData["Title"] = "ReadSelectStory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <h2>");
#nullable restore
#line 12 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Story\ReadSelectStory.cshtml"
   Write(Html.DisplayFor(model => model.Story.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p class=\"text-lg-right text-decoration-none\">Category: <b>");
#nullable restore
#line 13 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Story\ReadSelectStory.cshtml"
                                                          Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </p>\r\n    \r\n    \r\n    <p class=\"col-xs-offset-2 col-sm-offset-2 col-xs-8 col-sm-8 text-justify\">\r\n        ");
#nullable restore
#line 17 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Story\ReadSelectStory.cshtml"
   Write(Html.DisplayFor(model => model.Story.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n\r\n    <p class=\"text-lg-right\">Author: <b>");
#nullable restore
#line 21 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Story\ReadSelectStory.cshtml"
                                   Write(Html.DisplayFor(model => model.Story.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </p>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FFK.ViewModels.ReadStoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
