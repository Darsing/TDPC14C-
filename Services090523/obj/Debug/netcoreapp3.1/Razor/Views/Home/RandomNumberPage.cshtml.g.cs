#pragma checksum "C:\xampp\htdocs\TDPC14C-\Services090523\Views\Home\RandomNumberPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edf907e0e7c56003b293aa975d70ea4993a90458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RandomNumberPage), @"mvc.1.0.view", @"/Views/Home/RandomNumberPage.cshtml")]
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
#line 1 "C:\xampp\htdocs\TDPC14C-\Services090523\Views\_ViewImports.cshtml"
using Services090523;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\TDPC14C-\Services090523\Views\_ViewImports.cshtml"
using Services090523.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf907e0e7c56003b293aa975d70ea4993a90458", @"/Views/Home/RandomNumberPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d74fc70763d9c7fc5adf267cf2ccbf86bb1b3c8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_RandomNumberPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RandomNumberPageModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\xampp\htdocs\TDPC14C-\Services090523\Views\Home\RandomNumberPage.cshtml"
  
    ViewData["Title"] = "Random page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\xampp\htdocs\TDPC14C-\Services090523\Views\Home\RandomNumberPage.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>il numero è : ");
#nullable restore
#line 7 "C:\xampp\htdocs\TDPC14C-\Services090523\Views\Home\RandomNumberPage.cshtml"
            Write(Model.RandomNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RandomNumberPageModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
