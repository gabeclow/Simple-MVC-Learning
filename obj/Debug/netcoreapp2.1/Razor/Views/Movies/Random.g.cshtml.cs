#pragma checksum "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Movies\Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bca8a4be0946451010f6831cb27ce6b2a41f55f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Random), @"mvc.1.0.view", @"/Views/Movies/Random.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Random.cshtml", typeof(AspNetCore.Views_Movies_Random))]
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
#line 1 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\_ViewImports.cshtml"
using gclowPortal;

#line default
#line hidden
#line 2 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\_ViewImports.cshtml"
using gclowPortal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bca8a4be0946451010f6831cb27ce6b2a41f55f", @"/Views/Movies/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01ab411d785f19fa465b30ae2606210627ed9a5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gclowPortal.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Movies\Random.cshtml"
  
    ViewData["Title"] = "Random";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(122, 10, true);
            WriteLiteral("\r\n\r\n\r\n<h1>");
            EndContext();
            BeginContext(133, 8, false);
#line 9 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Movies\Random.cshtml"
Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(141, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(144, 10, false);
#line 9 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Movies\Random.cshtml"
          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(154, 5, true);
            WriteLiteral("</h1>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gclowPortal.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591