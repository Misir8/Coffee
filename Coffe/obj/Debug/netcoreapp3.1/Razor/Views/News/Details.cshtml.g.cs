#pragma checksum "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "645f087e784f246c3c481ea428799bc157b7a0f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Details), @"mvc.1.0.view", @"/Views/News/Details.cshtml")]
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
#nullable restore
#line 2 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"645f087e784f246c3c481ea428799bc157b7a0f9", @"/Views/News/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c295cd374c954c518b34dd5c7ce5359fc33336b", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive mb10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
  
    ViewBag.Title = Localizer["News"];
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""tp-breadcrumb"" class=""tp-breadcrumb"">
    <!-- breadcrumb -->
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ol class=""breadcrumb"">
                    <li>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "645f087e784f246c3c481ea428799bc157b7a0f95950", async() => {
#nullable restore
#line 16 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                               Write(Localizer["Home"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"active\">\r\n");
#nullable restore
#line 19 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                         if (ViewBag.Culture == "az")
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                       Write(Model.News.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                             
                        }
                        else if (ViewBag.Culture == "en")
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                       Write(Model.News.TitleEn);

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                               
                        }
                        else if (ViewBag.Culture == "ru")
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                       Write(Model.News.TitleRu);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                               
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </li>
                </ol>
            </div>
        </div>
    </div>
</div>
<!-- /.breadcrumb -->
<div id=""main-container"" class=""main-container"">
    <!-- main container -->
    <div class=""container"">
        <div class=""row"">
            <div id=""tp-blog"" class=""tp-blog"">
                <!-- Tp Blog -->
                <div class=""col-md-8 tp-left"">
                    <!-- Tp Left Sidebar -->
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <!-- Tp Blog Post -->
                            <div class=""post-holder border-bottom"">
                                <div class=""post-img mb30"">
                                    <!-- pic -->
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "645f087e784f246c3c481ea428799bc157b7a0f910180", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1855, "~/img/", 1855, 6, true);
#nullable restore
#line 52 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
AddHtmlAttributeValue("", 1861, Model.News.Image, 1861, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 52 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
AddHtmlAttributeValue("", 1908, Model.News.Image, 1908, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <div class=\"post-sticky\"></div>\r\n                                </div>\r\n                                <!-- /.pic -->\r\n");
#nullable restore
#line 56 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                 if (ViewBag.Culture == "az")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"post-header mb30\">\r\n                                        <h1 class=\"post-title mb10\">");
#nullable restore
#line 59 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                               Write(Model.News.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                    </div>
                                    <!-- /.Tp meta -->
                                    <div class=""post-content mb40"">
                                        <p style=""margin:0in 0in 8pt; text-align:start; -webkit-text-stroke-width:0px"">
                                            ");
#nullable restore
#line 64 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                       Write(Html.Raw(Model.News.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n\r\n\r\n                                    </div>\r\n");
#nullable restore
#line 69 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                }
                                else if (ViewBag.Culture == "en")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"post-header mb30\">\r\n                                        <h1 class=\"post-title mb10\">");
#nullable restore
#line 73 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                               Write(Model.News.TitleEn);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                    </div>
                                    <!-- /.Tp meta -->
                                    <div class=""post-content mb40"">
                                        <p style=""margin:0in 0in 8pt; text-align:start; -webkit-text-stroke-width:0px"">
                                            ");
#nullable restore
#line 78 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                       Write(Html.Raw(Model.News.ContentEn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n\r\n\r\n                                    </div>\r\n");
#nullable restore
#line 83 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                }
                                else if (ViewBag.Culture == "ru")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"post-header mb30\">\r\n                                        <h1 class=\"post-title mb10\">");
#nullable restore
#line 87 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                               Write(Model.News.TitleRu);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                    </div>
                                    <!-- /.Tp meta -->
                                    <div class=""post-content mb40"">
                                        <p style=""margin:0in 0in 8pt; text-align:start; -webkit-text-stroke-width:0px"">
                                            ");
#nullable restore
#line 92 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                       Write(Html.Raw(Model.News.ContentRu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n\r\n\r\n                                    </div>\r\n");
#nullable restore
#line 97 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""post-related mb40"">
                                    <div class=""row"">
                                    </div>
                                </div>
                            </div>
                            <!-- /.Tp Blog Post -->
                        </div>
                        <!-- /.related post -->

                    </div>


                </div>
                <!-- /.Tp Blog -->
            </div>
            <!-- /.Tp Left Sidebar -->
            <div class=""col-md-4 right-sidebar"">
                <!-- Right Sidebar -->
                <div class=""row"">
                    <div class=""col-md-12"">
                        <!-- Recent Post Widget -->
                        <div class=""tp-recent-post-widget widget"">
                            <div class=""tp-bg-border tp-bg-box"">
                                <!-- bg box -->
                                <h2>");
#nullable restore
#line 122 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                               Write(Localizer["LastNews"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            </div>\r\n                            <!-- /.bg box -->\r\n                            <div class=\"tp-bg-box\">\r\n                                <ul class=\"listnone\">\r\n");
#nullable restore
#line 127 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                     foreach (var news in @Model.Newses)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <li>
                                            <div class=""recent-block mb20"">
                                                <div class=""row"">
                                                    <div class=""col-md-4"">
                                                        <a>
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "645f087e784f246c3c481ea428799bc157b7a0f918947", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6058, "~/img/", 6058, 6, true);
#nullable restore
#line 134 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
AddHtmlAttributeValue("", 6064, news.Image, 6064, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 134 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
AddHtmlAttributeValue("", 6082, news.Image, 6082, 11, false);

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
            WriteLiteral(@"
                                                        </a>
                                                    </div>
                                                    <div class=""col-md-8"">
                                                        <h4 class=""recent-title mb10"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "645f087e784f246c3c481ea428799bc157b7a0f921289", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 140 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                                 if (ViewBag.Culture == "az")
                                                                {
                                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                               Write(Model.News.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                                                     
                                                                }
                                                                else if (ViewBag.Culture == "en")
                                                                {
                                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                               Write(Model.News.TitleEn);

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                                                       
                                                                }
                                                                else if (ViewBag.Culture == "ru")
                                                                {
                                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                               Write(Model.News.TitleRu);

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                                                       
                                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 139 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                                                                                            WriteLiteral(news.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </h4>
                                                        <div class=""post-meta"">
                                                            <!-- post meta -->
                                                        </div>
                                                        <!-- /.post meta -->
                                                    </div>
                                                </div>
                                            </div>
                                        </li>
");
#nullable restore
#line 162 "C:\Users\User\RiderProjects\Coffe\Coffe\Views\News\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /.Right Sidebar -->
        </div>
    </div>
</div>
<!-- /.main container -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
