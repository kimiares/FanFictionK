#pragma checksum "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Admin\GetAllRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf98d66c2792d02f032c6b8d30e102fbc2eb0cc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetAllRoles), @"mvc.1.0.view", @"/Views/Admin/GetAllRoles.cshtml")]
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
#line 2 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\_ViewImports.cshtml"
using FFK.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf98d66c2792d02f032c6b8d30e102fbc2eb0cc7", @"/Views/Admin/GetAllRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0256a96dce335abdd5e5bc98b9094ab4b9cb50a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetAllRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Admin\GetAllRoles.cshtml"
  
    ViewData["Title"] = "GetAllRoles";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row border-dark\">\r\n    <div class=\"col-md-2\">\r\n        ");
#nullable restore
#line 10 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Admin\GetAllRoles.cshtml"
   Write(await Html.PartialAsync("_AdminPageLayout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div div class=\"col-md-10\">\r\n\r\n        <table class=\"table\">\r\n");
#nullable restore
#line 15 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Admin\GetAllRoles.cshtml"
             foreach (var role in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Admin\GetAllRoles.cshtml"
                   Write(role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 20 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Admin\GetAllRoles.cshtml"
                   Write(role.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Admin\GetAllRoles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
