#pragma checksum "C:\Users\User\RiderProjects\Coffe\Coffe\Areas\Admin\Views\Shared\_NotificationWarningPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "311edf893bfdb2e9e2e2161073d8033fe1bbc4d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__NotificationWarningPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_NotificationWarningPartial.cshtml")]
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
#line 1 "C:\Users\User\RiderProjects\Coffe\Coffe\Areas\Admin\Views\_ViewImports.cshtml"
using Coffe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\Coffe\Coffe\Areas\Admin\Views\_ViewImports.cshtml"
using Coffe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\RiderProjects\Coffe\Coffe\Areas\Admin\Views\_ViewImports.cshtml"
using Coffe.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"311edf893bfdb2e9e2e2161073d8033fe1bbc4d2", @"/Areas/Admin/Views/Shared/_NotificationWarningPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64e7899b0dd8948a528182771f5274504626c37b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__NotificationWarningPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\RiderProjects\Coffe\Coffe\Areas\Admin\Views\Shared\_NotificationWarningPartial.cshtml"
 if (TempData["warning"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">");
#nullable restore
#line 3 "C:\Users\User\RiderProjects\Coffe\Coffe\Areas\Admin\Views\Shared\_NotificationWarningPartial.cshtml"
                                Write(TempData["warning"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 4 "C:\Users\User\RiderProjects\Coffe\Coffe\Areas\Admin\Views\Shared\_NotificationWarningPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
