#pragma checksum "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b1fde18aa9600c115bad5cdc03e9a20cdb42476"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portal_EditCustomFilter), @"mvc.1.0.view", @"/Views/Portal/EditCustomFilter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Portal/EditCustomFilter.cshtml", typeof(AspNetCore.Views_Portal_EditCustomFilter))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1fde18aa9600c115bad5cdc03e9a20cdb42476", @"/Views/Portal/EditCustomFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01ab411d785f19fa465b30ae2606210627ed9a5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Portal_EditCustomFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
  
    ViewData["Title"] = "EditCustomFilter";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(101, 1196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "235cf2683d52405eb52464849b349661", async() => {
                BeginContext(107, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(217, 64, true);
                WriteLiteral("    <script src=\"//cdn.tinymce.com/4/tinymce.min.js\"></script>\r\n");
                EndContext();
                BeginContext(387, 903, true);
                WriteLiteral(@"
    <script>
        tinymce.init({
            //selector: 'textarea.tinyMceDisclaimer',
            selector: 'textarea',

            force_br_newlines: false,
            force_p_newlines: false,
            forced_root_block: '',
            height: 100,
            //menubar:false,
            plugins: [
                'code advlist autolink lists link image charmap hr anchor pagebreak',
                'searchreplace visualblocks visualchars',
                'insertdatetime media nonbreaking contextmenu directionality',
                'emoticons template paste textcolor colorpicker textpattern imagetools codesample toc'
            ],
            //toolbar: 'code visualchars | undo redo | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image | forecolor backcolor',
        });

    </script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1297, 152, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<h2>Edit Custom Filter</h2>\r\n\r\n<div class=\"col-sm-6\" style=\"padding-top:3.5em\">\r\n\r\n\r\n    <div class=\"col-sm-6\">\r\n        <div class=\"col-sm-12\">");
            EndContext();
            BeginContext(1450, 18, false);
#line 43 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                          Write(Html.Label("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1470, 20, false);
#line 43 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                                              Write(Html.TextBox("name"));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 91, true);
            WriteLiteral("</div>\r\n        <div class=\"col-sm-12\" style=\"padding-bottom:10px\">&nbsp;&nbsp;&nbsp;&nbsp;");
            EndContext();
            BeginContext(1582, 17, false);
#line 44 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                                                                              Write(Html.Label("Tag"));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1601, 19, false);
#line 44 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                                                                                                 Write(Html.TextBox("Tag"));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 179, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"col-sm-6\" style=\"padding-bottom:50px\">\r\n\r\n        <div class=\"col-sm-12\">\r\n            Filter Type    <div class=\"col-sm-12\">\r\n                ");
            EndContext();
            BeginContext(1800, 41, false);
#line 50 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
           Write(Html.RadioButton("custradio", "Flexible"));

#line default
#line hidden
            EndContext();
            BeginContext(1841, 84, true);
            WriteLiteral(" Flexible\r\n            </div>\r\n            <div class=\"col-sm-12\">\r\n                ");
            EndContext();
            BeginContext(1926, 39, false);
#line 53 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
           Write(Html.RadioButton("custradio", "Strict"));

#line default
#line hidden
            EndContext();
            BeginContext(1965, 82, true);
            WriteLiteral(" Strict\r\n            </div>\r\n            <div class=\"col-sm-12\">\r\n                ");
            EndContext();
            BeginContext(2048, 36, false);
#line 56 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
           Write(Html.RadioButton("custradio", "Tag"));

#line default
#line hidden
            EndContext();
            BeginContext(2084, 62, true);
            WriteLiteral(" Tag\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(2147, 31, false);
#line 62 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
Write(Html.Label("Short Description"));

#line default
#line hidden
            EndContext();
            BeginContext(2179, 26, false);
#line 62 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                               Write(Html.TextArea("ShortDesc"));

#line default
#line hidden
            EndContext();
            BeginContext(2205, 676, true);
            WriteLiteral(@"



</div>


<div class=""col-sm-6"">
    <H2>Icon</H2>


    <div class=""custom-file col-sm-6"">
        <input type=""file"" class=""custom-file-input"" id=""inputGroupFile01"" aria-describedby=""inputGroupFileAddon01"">
    </div>
    <div class=""col-sm-6"">
        <input type=""color"" id=""mainColor"" name=""mainColor"" value=""#8abbff"">
        <label for=""mainColor"">On Color</label>

        <input type=""color"" id=""colorHover"" name=""colorHover"" value=""#8aa9ff"">
        <label for=""colorHover"">Off Color</label>
    </div>

    <h4 class=""col-sm-12"" style=""text-align:center"">Definition Settings</h4>
    <div class=""col-sm-6"">
        <div class=""col-sm-12"">");
            EndContext();
            BeginContext(2882, 24, false);
#line 86 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                          Write(Html.CheckBox("publish"));

#line default
#line hidden
            EndContext();
            BeginContext(2907, 21, false);
#line 86 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                                                   Write(Html.Label("Publish"));

#line default
#line hidden
            EndContext();
            BeginContext(2928, 39, true);
            WriteLiteral("</div>\r\n        <div class=\"col-sm-12\">");
            EndContext();
            BeginContext(2968, 24, false);
#line 87 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                          Write(Html.CheckBox("ShowDef"));

#line default
#line hidden
            EndContext();
            BeginContext(2993, 29, false);
#line 87 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                                                   Write(Html.Label("Show Definition"));

#line default
#line hidden
            EndContext();
            BeginContext(3022, 79, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"col-sm-6\">\r\n        <div class=\"col-sm-12\">");
            EndContext();
            BeginContext(3102, 28, false);
#line 90 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                          Write(Html.CheckBox("showOnIndex"));

#line default
#line hidden
            EndContext();
            BeginContext(3131, 37, false);
#line 90 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                                                       Write(Html.Label("Show Icon on Index Page"));

#line default
#line hidden
            EndContext();
            BeginContext(3168, 39, true);
            WriteLiteral("</div>\r\n        <div class=\"col-sm-12\">");
            EndContext();
            BeginContext(3208, 27, false);
#line 91 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                          Write(Html.CheckBox("showOnMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(3236, 36, false);
#line 91 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
                                                      Write(Html.Label("Show Icon on Menu Page"));

#line default
#line hidden
            EndContext();
            BeginContext(3272, 90, true);
            WriteLiteral("</div>\r\n    </div>\r\n\r\n    <div style=\"text-align:center\"><h4>Definition</h4></div>\r\n\r\n    ");
            EndContext();
            BeginContext(3363, 27, false);
#line 96 "C:\Users\gclow\source\repos\gclowPortal\gclowPortal\Views\Portal\EditCustomFilter.cshtml"
Write(Html.TextArea("definition"));

#line default
#line hidden
            EndContext();
            BeginContext(3390, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
