#pragma checksum "C:\xampp\htdocs\TDPC14C-\WebApplicationTest\Views\Home\contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133eb6bb4886f578b7eb17df9986bfe30593c4a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_contact), @"mvc.1.0.view", @"/Views/Home/contact.cshtml")]
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
#line 1 "C:\xampp\htdocs\TDPC14C-\WebApplicationTest\Views\_ViewImports.cshtml"
using WebApplicationTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\TDPC14C-\WebApplicationTest\Views\_ViewImports.cshtml"
using WebApplicationTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133eb6bb4886f578b7eb17df9986bfe30593c4a3", @"/Views/Home/contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04da6a1326290079c73c353001a5770918c15004", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\xampp\htdocs\TDPC14C-\WebApplicationTest\Views\Home\contact.cshtml"
  
    ViewData["Title"] = "Contacts";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\xampp\htdocs\TDPC14C-\WebApplicationTest\Views\Home\contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("<p>this is the contacts page.</p>\r\n<p>Nome : ");
#nullable restore
#line 7 "C:\xampp\htdocs\TDPC14C-\WebApplicationTest\Views\Home\contact.cshtml"
     Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Nome : ");
#nullable restore
#line 8 "C:\xampp\htdocs\TDPC14C-\WebApplicationTest\Views\Home\contact.cshtml"
     Write(Model.Cognome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591