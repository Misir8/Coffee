#pragma checksum "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "491c8f8eb4467caa0f2d7c1f56a92f2d830e38bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\_ViewImports.cshtml"
using Coffe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\_ViewImports.cshtml"
using Coffe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\_ViewImports.cshtml"
using Coffe.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"491c8f8eb4467caa0f2d7c1f56a92f2d830e38bd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c295cd374c954c518b34dd5c7ce5359fc33336b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("coffee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            DefineSection("Style", async() => {
                WriteLiteral("\r\n    <style>\r\n        .menu-image a{\r\n        height: 300px!important;\r\n        }\r\n        .menu-image a img{\r\n        height: 100%!important;\r\n        object-fit: cover!important;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n<!-- Background Area Start -->\r\n<section class=\"slider-area\">\r\n    <div class=\"slider-wrapper\">\r\n");
#nullable restore
#line 21 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
         foreach (var slider in Model.Sliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"single-slide\"");
            BeginWriteAttribute("style", " style=\"", 496, "\"", 554, 4);
            WriteAttributeValue("", 504, "background-image:", 504, 17, true);
            WriteAttributeValue(" ", 521, "url(\'img/slider/", 522, 17, true);
#nullable restore
#line 23 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
WriteAttributeValue("", 538, slider.Image, 538, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 551, "\');", 551, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""banner-content"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1"">
                                <div class=""text-content-wrapper"">
                                    <div class=""text-content text-center"">
                                        <h1>");
#nullable restore
#line 30 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                                       Write(slider.Subtitle.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                        <div class=""banner-btn"">
                                            <a class=""default-btn"" href=""reservation.html"">
                                                <span>Reservation</span>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 43 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- Background Area End -->\r\n<!-- Contact Info Start -->\r\n<section class=\"contact-area fix pb-30\">\r\n");
#nullable restore
#line 49 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
     foreach (var contactInfo in Model.ContactInfos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-contact\">\r\n            <div class=\"information text-center\">\r\n                <h4>");
#nullable restore
#line 53 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
               Write(Html.Raw(contactInfo.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 56 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n<!-- Contact Info End -->\r\n<!-- About Area Start -->\r\n<section class=\"about-area pt-70 pb-100\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 63 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
             foreach (var about in Model.Abouts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-sm-6\">\r\n                    <div class=\"about-container\">\r\n                        <div class=\"about-text\">\r\n                        \r\n                            <h3>");
#nullable restore
#line 69 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                           Write(about.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 70 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                          Write(about.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "491c8f8eb4467caa0f2d7c1f56a92f2d830e38bd9997", async() => {
                WriteLiteral("\r\n                                <span>Ətraflı</span>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6 col-sm-6 hidden-xs\">\r\n                    <div class=\"about-image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "491c8f8eb4467caa0f2d7c1f56a92f2d830e38bd11751", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2864, "~/img/about/", 2864, 12, true);
#nullable restore
#line 79 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2876, about.Image, 2876, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 82 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<!-- About Area End -->
<!-- Special Area Strat -->
<section class=""special-area bg-light ptb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-md-offset-3"">
                <div class=""section-title text-center"">
                    <h1>Special koffee</h1>
                    <span>
                        <img src=""img/icons/koffee.png""");
            BeginWriteAttribute("alt", " alt=\"", 3408, "\"", 3414, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </span>
                    <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since. </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <div class=""special-item"">
            <div class=""item-content"">
                <img src=""img/koffee/1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3845, "\"", 3851, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""item-hover text-center"">
                    <div class=""hover-text"">
                        <h1>
                            <a href=""menu.html"">Americano koffee</a>
                        </h1>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since.</p>
                        <span class=""price"">$20.00</span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""special-item"">
            <div class=""item-content"">
                <img src=""img/koffee/2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4527, "\"", 4533, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""item-hover text-center"">
                    <div class=""hover-text"">
                        <h1>
                            <a href=""menu.html"">Moccha koffee</a>
                        </h1>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since.</p>
                        <span class=""price"">$10.00</span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""special-item"">
            <div class=""item-content"">
                <img src=""img/koffee/3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5206, "\"", 5212, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""item-hover text-center"">
                    <div class=""hover-text"">
                        <h1>
                            <a href=""menu.html"">Black koffee</a>
                        </h1>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since.</p>
                        <span class=""price"">$15.00</span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""special-item"">
            <div class=""item-content"">
                <img src=""img/koffee/3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5884, "\"", 5890, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""item-hover text-center"">
                    <div class=""hover-text"">
                        <h1>
                            <a href=""menu.html"">Cold koffee</a>
                        </h1>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since.</p>
                        <span class=""price"">$15.00</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Special Area End -->
<!-- Booking Area Start -->
<section class=""booking-area ptb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-md-offset-3"">
                <div class=""section-title text-center"">
                    <h1>Dəyərlərımız</h1>
                    <span>
                        <img src=""img/icons/koffee.png"" alt=""coffee"">
                    </span>
");
#nullable restore
#line 172 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                     foreach (var value in Model.Values)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 174 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                      Write(value.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 175 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>
<!-- Booking Area End -->
<!-- Advertise Area Start -->
<section class=""advertise-area bg-1 ptb-100 overlay-1"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-10 col-md-offset-1"">
                <div class=""advertise-text text-center"">
                    <h1>Tariximiz</h1>
");
#nullable restore
#line 189 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                     foreach (var history in Model.Histories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 191 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                      Write(history.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 192 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>
<!-- Advertise Area End -->
<!-- Menu Area Start -->
<section class=""menu-area ptb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-md-offset-3"">
                <div class=""section-title text-center"">
                    <h1>Məhsullar</h1>
                    <span>
                        <img src=""img/icons/koffee.png""");
            BeginWriteAttribute("alt", " alt=\"", 8085, "\"", 8091, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 213 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
             foreach (var product in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 col-sm-4\">\r\n                    <div class=\"single-menu text-center\">\r\n                        <div class=\"menu-image\">\r\n                            <span>");
#nullable restore
#line 218 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                             Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <a href=\"menu.html\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 8581, "\"", 8612, 2);
            WriteAttributeValue("", 8587, "img/koffee/", 8587, 11, true);
#nullable restore
#line 220 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
WriteAttributeValue("", 8598, product.Image, 8598, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8613, "\"", 8619, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n                        <h4>\r\n                            <a href=\"menu.html\">");
#nullable restore
#line 224 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                                           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </h4>\r\n                        <span>");
#nullable restore
#line 226 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                         Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 229 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            <div class=\"col-md-12 text-center menu-btn col-sm-12 col-xs-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "491c8f8eb4467caa0f2d7c1f56a92f2d830e38bd23216", async() => {
                WriteLiteral("\r\n                    <span>Bütün məhsullar</span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>
<!-- Menu Area End -->
<!-- Event Area Start -->
<section class=""event-area ptb-100 bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-10 col-md-offset-1"">
                <div class=""event-text text-center"">
                    <h1>Məqsəd və missiyamız</h1>
");
#nullable restore
#line 247 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                     foreach (var target in Model.Targets)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 249 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                      Write(target.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 250 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Event Area End -->\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
