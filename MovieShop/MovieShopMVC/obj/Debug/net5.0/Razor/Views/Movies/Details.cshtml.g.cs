#pragma checksum "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce40add2e6053145026b67c66d7e5e130fc977f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce40add2e6053145026b67c66d7e5e130fc977f9", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6112aabca9b932007558671ce74e32c023ef6c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationCore.Models.TableViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Movie Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
 foreach (var item in Model.Movies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"rounded\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row\"");
            BeginWriteAttribute("style", " style=\"", 235, "\"", 342, 11);
            WriteAttributeValue("", 243, "background-image:", 243, 17, true);
            WriteAttributeValue(" ", 260, "linear-gradient(rgba(0,", 261, 24, true);
            WriteAttributeValue(" ", 284, "0,", 285, 3, true);
            WriteAttributeValue(" ", 287, "0,", 288, 3, true);
            WriteAttributeValue(" ", 290, "0.8),", 291, 6, true);
            WriteAttributeValue(" ", 296, "rgba(0,", 297, 8, true);
            WriteAttributeValue(" ", 304, "0,", 305, 3, true);
            WriteAttributeValue(" ", 307, "0,", 308, 3, true);
            WriteAttributeValue(" ", 310, "0.8)),url(\'", 311, 12, true);
#nullable restore
#line 12 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 322, item.BackdropUrl, 322, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 339, "\');", 339, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"col-sm\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 408, "\"", 429, 1);
#nullable restore
#line 14 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 414, item.PosterUrl, 414, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 430, "\"", 444, 1);
#nullable restore
#line 14 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 436, item.Id, 436, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-sm text-white\">\r\n                    <h3><strong>");
#nullable restore
#line 17 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n                    <span class=\"text-muted\" style=\"font-size:smaller;\">");
#nullable restore
#line 18 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                   Write(item.Tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br /><br />\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-4\"><h6 class=\"text-muted\"><strong>");
#nullable restore
#line 20 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                        Write(item.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m  |  ");
#nullable restore
#line 20 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                            Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6></div>\r\n                        <div class=\"col-sm\">\r\n");
#nullable restore
#line 22 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                             foreach (var genre in Model.Genres)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-dark badge-pill\">");
#nullable restore
#line 24 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                     Write(genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 25 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <br />\r\n                    <div>\r\n\r\n                    </div>\r\n                    <p>\r\n                        ");
#nullable restore
#line 33 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                   Write(item.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                <div class=""col-sm"">
                    <div>
                        <button type=""button"" class=""btn btn-dark btn-lg"">
                            <i class=""bi bi-pencil-square""></i>
                            REVIEW
                        </button>
                    </div>
                    <div><button type=""button"" class=""btn btn-light btn-lg"">BUY $");
#nullable restore
#line 43 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </button></div>
                </div>
            </div>
            <div class=""row mt-4"">
                <div class=""col-sm-4 bg-light"">
                    <h4><strong>MOVIE FACT</strong></h4>
                    <ul class=""list-group list-group-flush"">
                        <li class=""list-group-item"">
                            <i class=""fa fa-calendar"" aria-hidden=""true""></i>
                            Release Date  <span class=""badge badge-dark badge-pill"">");
#nullable restore
#line 52 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            <i class=\"bi bi-hourglass-split\"></i>\r\n                            Run Time  <span class=\"badge badge-dark badge-pill\">");
#nullable restore
#line 56 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                           Write(item.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m</span>\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            <i class=\"bi bi-cash-coin\"></i>\r\n                            Box Office  <span class=\"badge badge-dark badge-pill\">");
#nullable restore
#line 60 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                             Write(item.Revenue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            <i class=\"bi bi-currency-dollar\"></i>\r\n                            Budget  <span class=\"badge badge-dark badge-pill\">");
#nullable restore
#line 64 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                         Write(item.Budget);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            <i class=\"fa fa-imdb\"></i>\r\n                            <a");
            BeginWriteAttribute("href", " href=", 3217, "", 3236, 1);
#nullable restore
#line 68 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 3223, item.ImdbUrl, 3223, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration:none;color:black;""><i class=""fa fa-share-square-o""></i></a>
                        </li>
                    </ul>
                </div>
                <div class=""col-sm-1""></div>
                <div class=""col-sm-4"">
                    <h4><strong>CAST</strong></h4>
                    <ul class=""list-group list-group-flush"">
                        <li></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 82 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationCore.Models.TableViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591