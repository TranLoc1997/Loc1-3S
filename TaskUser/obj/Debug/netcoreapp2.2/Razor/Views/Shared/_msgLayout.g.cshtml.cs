#pragma checksum "/home/local/3SI/loc.tv/Desktop/Loc-3S/Loc-3S/TaskUser/Views/Shared/_msgLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a09e161514942aa30f57f31d4d9a9fe0d58a56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__msgLayout), @"mvc.1.0.view", @"/Views/Shared/_msgLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_msgLayout.cshtml", typeof(AspNetCore.Views_Shared__msgLayout))]
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
#line 1 "/home/local/3SI/loc.tv/Desktop/Loc-3S/Loc-3S/TaskUser/Views/_ViewImports.cshtml"
using TaskUser;

#line default
#line hidden
#line 2 "/home/local/3SI/loc.tv/Desktop/Loc-3S/Loc-3S/TaskUser/Views/_ViewImports.cshtml"
using TaskUser.Models;

#line default
#line hidden
#line 4 "/home/local/3SI/loc.tv/Desktop/Loc-3S/Loc-3S/TaskUser/Views/_ViewImports.cshtml"
using TaskUser.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a09e161514942aa30f57f31d4d9a9fe0d58a56", @"/Views/Shared/_msgLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d5cba43507413bc679cf4227df7d8ac0e05118c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__msgLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/local/3SI/loc.tv/Desktop/Loc-3S/Loc-3S/TaskUser/Views/Shared/_msgLayout.cshtml"
 if (TempData["Successfuly"] != null)
{

#line default
#line hidden
            BeginContext(42, 72, true);
            WriteLiteral("    <div class=\"alert alert-info\"style=\"width: 200px\">\r\n        <strong>");
            EndContext();
            BeginContext(115, 23, false);
#line 4 "/home/local/3SI/loc.tv/Desktop/Loc-3S/Loc-3S/TaskUser/Views/Shared/_msgLayout.cshtml"
           Write(TempData["Successfuly"]);

#line default
#line hidden
            EndContext();
            BeginContext(138, 119, true);
            WriteLiteral("</strong>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">x</button>\r\n    </div>\r\n");
            EndContext();
#line 7 "/home/local/3SI/loc.tv/Desktop/Loc-3S/Loc-3S/TaskUser/Views/Shared/_msgLayout.cshtml"
 
}

#line default
#line hidden
#line 9 "/home/local/3SI/loc.tv/Desktop/Loc-3S/Loc-3S/TaskUser/Views/Shared/_msgLayout.cshtml"
 if (TempData["Failure"] != null)
{

#line default
#line hidden
            BeginContext(301, 72, true);
            WriteLiteral("    <div class=\"alert alert-info\"style=\"width: 200px\">\r\n        <strong>");
            EndContext();
            BeginContext(374, 19, false);
#line 12 "/home/local/3SI/loc.tv/Desktop/Loc-3S/Loc-3S/TaskUser/Views/Shared/_msgLayout.cshtml"
           Write(TempData["Failure"]);

#line default
#line hidden
            EndContext();
            BeginContext(393, 119, true);
            WriteLiteral("</strong>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">x</button>\r\n    </div>\r\n");
            EndContext();
#line 15 "/home/local/3SI/loc.tv/Desktop/Loc-3S/Loc-3S/TaskUser/Views/Shared/_msgLayout.cshtml"
}

#line default
#line hidden
            BeginContext(515, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<CommonResource> Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<PasswordResource> PasswordLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<LoginResource> LoginLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<StoreResource> StoreLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<StockResource> StockLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<ProductResource> ProductLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<UserResource> UserLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<CategoryResource> CategoryLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<BrandResource> BrandLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
