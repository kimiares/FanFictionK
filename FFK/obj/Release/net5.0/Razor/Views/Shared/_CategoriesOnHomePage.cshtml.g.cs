#pragma checksum "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Shared\_CategoriesOnHomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a26eff0f447cd3fe2df89a3b84b401b85feec3f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CategoriesOnHomePage), @"mvc.1.0.view", @"/Views/Shared/_CategoriesOnHomePage.cshtml")]
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
#line 2 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Shared\_CategoriesOnHomePage.cshtml"
using FFK.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a26eff0f447cd3fe2df89a3b84b401b85feec3f6", @"/Views/Shared/_CategoriesOnHomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0256a96dce335abdd5e5bc98b9094ab4b9cb50a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CategoriesOnHomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FFK.ViewModels.StoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Shared\_CategoriesOnHomePage.cshtml"
  
    ViewData["Title"] = "Category Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"list-group border-left \">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Shared\_CategoriesOnHomePage.cshtml"
     foreach (var c in Model.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item \">\r\n            ");
#nullable restore
#line 12 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Shared\_CategoriesOnHomePage.cshtml"
       Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 14 "C:\Users\Пользователь\source\repos\FFK\FFK\Views\Shared\_CategoriesOnHomePage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FFK.ViewModels.StoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591