#pragma checksum "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\User\Purchases.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fed38daac0c3fd088fe54116de9f62b06a2a6c04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Purchases), @"mvc.1.0.view", @"/Views/User/Purchases.cshtml")]
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
#line 1 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\_ViewImports.cshtml"
using MovieShopMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\_ViewImports.cshtml"
using MovieShopMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed38daac0c3fd088fe54116de9f62b06a2a6c04", @"/Views/User/Purchases.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6112aabca9b932007558671ce74e32c023ef6c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Purchases : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationCore.Models.UserPurchaseResponseModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\User\Purchases.cshtml"
   
    ViewData["Title"] = "Purchases Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"rounded\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\User\Purchases.cshtml"
             foreach (var movie in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-xl-2 col-sm-4 col-lg-3\">\r\n");
            WriteLiteral("                ");
#nullable restore
#line 13 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\User\Purchases.cshtml"
           Write(await Html.PartialAsync("_MoviePurchasedCard", movie));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n            </div>\r\n");
#nullable restore
#line 16 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\User\Purchases.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationCore.Models.UserPurchaseResponseModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
