#pragma checksum "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dcd713dda3210e9b0752c4a61bc63ddd2ad3d16"
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
#nullable restore
#line 2 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
using ApplicationCore.ServiceInterfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dcd713dda3210e9b0752c4a61bc63ddd2ad3d16", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6112aabca9b932007558671ce74e32c023ef6c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationCore.Models.TableViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-lg "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PurchaseAction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:175px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-lg px-0 mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFavorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFavorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Movie Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
 foreach (var item in Model.Movies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"rounded\">\r\n        <div class=\"container-fluid \">\r\n            <div class=\"row\"");
            BeginWriteAttribute("style", " style=\"", 413, "\"", 520, 11);
            WriteAttributeValue("", 421, "background-image:", 421, 17, true);
            WriteAttributeValue(" ", 438, "linear-gradient(rgba(0,", 439, 24, true);
            WriteAttributeValue(" ", 462, "0,", 463, 3, true);
            WriteAttributeValue(" ", 465, "0,", 466, 3, true);
            WriteAttributeValue(" ", 468, "0.8),", 469, 6, true);
            WriteAttributeValue(" ", 474, "rgba(0,", 475, 8, true);
            WriteAttributeValue(" ", 482, "0,", 483, 3, true);
            WriteAttributeValue(" ", 485, "0,", 486, 3, true);
            WriteAttributeValue(" ", 488, "0.8)),url(\'", 489, 12, true);
#nullable restore
#line 15 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 500, item.BackdropUrl, 500, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 517, "\');", 517, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"col-sm-4 pr-lg-0\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 596, "\"", 617, 1);
#nullable restore
#line 17 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 602, item.PosterUrl, 602, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 618, "\"", 632, 1);
#nullable restore
#line 17 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 624, item.Id, 624, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:240px;height:390px;\" class=\"float-right img-fluid\" />\r\n                </div>\r\n                <div class=\"col-sm-1 \"></div>\r\n                <div class=\"col-sm-5 text-white\">\r\n                    <h3><strong>");
#nullable restore
#line 21 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n                    <span class=\"text-muted\" style=\"font-size:smaller;\">");
#nullable restore
#line 22 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                   Write(item.Tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br /><br />\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-4\"><h6 class=\"text-muted\"><strong>");
#nullable restore
#line 24 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                        Write(item.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m  |  ");
#nullable restore
#line 24 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                            Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6></div>\r\n                        <div class=\"col-sm\">\r\n");
#nullable restore
#line 26 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                             foreach (var genre in Model.Genres)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-dark badge-pill\">");
#nullable restore
#line 28 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                     Write(genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 29 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"mb-lg-2\">\r\n                        <h4><span class=\"badge bg-success\">");
#nullable restore
#line 33 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                      Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                    </div>\r\n                    <p>\r\n                        ");
#nullable restore
#line 36 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                   Write(item.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                <div class=""col-sm "">
                    <div class=""row justify-content-end m-lg-3"">
                        <button type=""button"" class=""btn btn-dark btn-lg "" style=""width:175px;"">
                            <i class=""bi bi-pencil-square""></i>
                            REVIEW
                        </button>
                    </div>
                    <div class=""row justify-content-end m-lg-3"">
");
#nullable restore
#line 47 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                         if (_userService.IsAuthenticated)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                             if (await _userPurchaseService.IsMoviePurchased(_userService.UserId, item.Id))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a type=\"button\" class=\"btn btn-light btn-lg \"");
            BeginWriteAttribute("href", " href=", 2500, "", 2519, 1);
#nullable restore
#line 51 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2506, item.ImdbUrl, 2506, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:175px;\">\r\n                                    WATCH\r\n                                </a>\r\n");
#nullable restore
#line 54 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dcd713dda3210e9b0752c4a61bc63ddd2ad3d1614721", async() => {
                WriteLiteral("\r\n                                    BUY $");
#nullable restore
#line 58 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                    Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movieId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                                                                                                          WriteLiteral(item.Price);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["price"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-price", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["price"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dcd713dda3210e9b0752c4a61bc63ddd2ad3d1619159", async() => {
                WriteLiteral("\r\n                                BUY $");
#nullable restore
#line 65 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 67 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                         if (_userService.IsAuthenticated)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                             if (await _movieFavoriteService.IsFavoritedMovie(_userService.UserId, item.Id))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dcd713dda3210e9b0752c4a61bc63ddd2ad3d1621928", async() => {
                WriteLiteral("\r\n                                    <i class=\"bi bi-star-fill\"></i> RemoveFavorite\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movieId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 75 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dcd713dda3210e9b0752c4a61bc63ddd2ad3d1625110", async() => {
                WriteLiteral("\r\n                                    <i class=\"bi bi-star\"></i> AddFavorite\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movieId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 81 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                </div>
            </div>
            <div class=""row mt-3"">
                <div class=""col-sm-4 bg-light"">
                    <div>
                        <h4 class=""mt-2""><strong>MOVIE FACT</strong></h4>
                        <ul class=""list-group list-group-flush "">
                            <li class=""list-group-item bg-light"">
                                <i class=""fa fa-calendar"" aria-hidden=""true""></i>
                                Release Date  <span class=""badge badge-dark badge-pill"">");
#nullable restore
#line 94 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                   Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                            <li class=""list-group-item bg-light"">
                                <i class=""bi bi-hourglass-split""></i>
                                Run Time  <span class=""badge badge-dark badge-pill"">");
#nullable restore
#line 98 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                               Write(item.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" m</span>
                            </li>
                            <li class=""list-group-item bg-light"">
                                <i class=""bi bi-cash-coin""></i>
                                Box Office  <span class=""badge badge-dark badge-pill"">");
#nullable restore
#line 102 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                 Write(item.Revenue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                            <li class=""list-group-item bg-light"">
                                <i class=""bi bi-currency-dollar""></i>
                                Budget  <span class=""badge badge-dark badge-pill"">");
#nullable restore
#line 106 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                             Write(item.Budget);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li class=\"list-group-item bg-light\">\r\n                                <i class=\"fa fa-imdb\"></i>\r\n                                <a");
            BeginWriteAttribute("href", " href=", 6020, "", 6039, 1);
#nullable restore
#line 110 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 6026, item.ImdbUrl, 6026, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration:none;color:black;""><i class=""fa fa-share-square-o""></i></a>
                            </li>
                        </ul>
                    </div>
                    <br />
                    <div>
                        <h4 class=""mt-1""><strong>TRAILERS</strong></h4>
                        <ul class=""list-group list-group-flush "">
");
#nullable restore
#line 118 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                             foreach (var trailer in Model.Trailers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item bg-light \">\r\n                                    <i class=\"bi bi-play-btn-fill\"></i>&emsp;\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 6703, "\"", 6729, 1);
#nullable restore
#line 122 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 6710, trailer.TrailerUrl, 6710, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none;color:black;\">");
#nullable restore
#line 122 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                                       Write(trailer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 124 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                    </div>
                </div>
                <div class=""col-sm-1""></div>
                <div class=""col-sm-5"">
                    <h4 class=""mt-2""><strong>CAST</strong></h4>
                    <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 133 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                         foreach (var cast in Model.Casts)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"list-group-item\">\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-sm-2\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 7458, "\"", 7478, 1);
#nullable restore
#line 138 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 7465, cast.TmdbUrl, 7465, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 7530, "\"", 7553, 1);
#nullable restore
#line 139 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 7536, cast.ProfilePath, 7536, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Profile Link\" class=\"rounded-circle\" style=\"width:40px;height:60px;\">\r\n                                        </a>\r\n                                    </div>\r\n                                    <div class=\"col-sm\">");
#nullable restore
#line 142 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                   Write(cast.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"col-sm\">");
#nullable restore
#line 143 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                   Write(cast.Character);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                            </li>\r\n");
#nullable restore
#line 146 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 152 "D:\Downloads\Antra\SEP_Projects\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IFavoriteService _movieFavoriteService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPurchaseService _userPurchaseService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICurrentUserService _userService { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationCore.Models.TableViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
