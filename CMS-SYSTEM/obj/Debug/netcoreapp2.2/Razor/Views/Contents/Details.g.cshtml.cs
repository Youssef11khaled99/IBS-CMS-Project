#pragma checksum "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b0069700440402d125bb37885e7dc085f50e47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contents_Details), @"mvc.1.0.view", @"/Views/Contents/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contents/Details.cshtml", typeof(AspNetCore.Views_Contents_Details))]
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
#line 1 "D:\IBS\Core Project\CMS-SYSTEM\Views\_ViewImports.cshtml"
using CMS_SYSTEM;

#line default
#line hidden
#line 2 "D:\IBS\Core Project\CMS-SYSTEM\Views\_ViewImports.cshtml"
using CMS_SYSTEM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b0069700440402d125bb37885e7dc085f50e47", @"/Views/Contents/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"800befe70c00d8c944edbeff807e79a6362d136d", @"/Views/_ViewImports.cshtml")]
    public class Views_Contents_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS_SYSTEM.Models.Content>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Content</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(210, 40, false);
#line 14 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(250, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(314, 36, false);
#line 17 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(350, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(413, 41, false);
#line 20 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(454, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(518, 37, false);
#line 23 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(555, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(618, 51, false);
#line 26 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MetaDescription));

#line default
#line hidden
            EndContext();
            BeginContext(669, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(733, 47, false);
#line 29 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MetaDescription));

#line default
#line hidden
            EndContext();
            BeginContext(780, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(843, 40, false);
#line 32 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(883, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(947, 36, false);
#line 35 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(983, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1046, 43, false);
#line 38 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsValid));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1153, 39, false);
#line 41 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsValid));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1255, 48, false);
#line 44 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BaseWidgetId));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1367, 44, false);
#line 47 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.BaseWidgetId));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1474, 47, false);
#line 50 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1585, 43, false);
#line 53 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1691, 47, false);
#line 56 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1738, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1802, 43, false);
#line 59 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1845, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1908, 45, false);
#line 62 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1953, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2017, 41, false);
#line 65 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2058, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2121, 46, false);
#line 68 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2167, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2231, 42, false);
#line 71 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2273, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2336, 39, false);
#line 74 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pid));

#line default
#line hidden
            EndContext();
            BeginContext(2375, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2439, 35, false);
#line 77 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pid));

#line default
#line hidden
            EndContext();
            BeginContext(2474, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2537, 37, false);
#line 80 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.L));

#line default
#line hidden
            EndContext();
            BeginContext(2574, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2638, 38, false);
#line 83 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.L.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2676, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2723, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3b0069700440402d125bb37885e7dc085f50e4713851", async() => {
                BeginContext(2769, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "D:\IBS\Core Project\CMS-SYSTEM\Views\Contents\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2777, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2785, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3b0069700440402d125bb37885e7dc085f50e4716154", async() => {
                BeginContext(2807, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2823, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS_SYSTEM.Models.Content> Html { get; private set; }
    }
}
#pragma warning restore 1591
