#pragma checksum "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f90f5ec0bee3201340398140e613b09839363604"
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
#line 1 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\_ViewImports.cshtml"
using CMS_SYSTEM;

#line default
#line hidden
#line 2 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\_ViewImports.cshtml"
using CMS_SYSTEM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f90f5ec0bee3201340398140e613b09839363604", @"/Views/Contents/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"800befe70c00d8c944edbeff807e79a6362d136d", @"/Views/_ViewImports.cshtml")]
    public class Views_Contents_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS_SYSTEM.Models.Content>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Content</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(208, 40, false);
#line 14 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(248, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(310, 36, false);
#line 17 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(346, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(407, 41, false);
#line 20 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(448, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(510, 37, false);
#line 23 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(547, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(608, 51, false);
#line 26 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MetaDescription));

#line default
#line hidden
            EndContext();
            BeginContext(659, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(721, 47, false);
#line 29 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MetaDescription));

#line default
#line hidden
            EndContext();
            BeginContext(768, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(992, 43, true);
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1036, 43, false);
#line 38 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsValid));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1141, 39, false);
#line 41 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsValid));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1241, 48, false);
#line 44 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BaseWidgetId));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1351, 44, false);
#line 47 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.BaseWidgetId));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1456, 47, false);
#line 50 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1503, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1565, 43, false);
#line 53 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1608, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1669, 47, false);
#line 56 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1716, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1778, 43, false);
#line 59 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1821, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1882, 45, false);
#line 62 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1989, 41, false);
#line 65 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2030, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2091, 46, false);
#line 68 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2137, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2199, 42, false);
#line 71 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2302, 39, false);
#line 74 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pid));

#line default
#line hidden
            EndContext();
            BeginContext(2341, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2403, 35, false);
#line 77 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pid));

#line default
#line hidden
            EndContext();
            BeginContext(2438, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2499, 37, false);
#line 80 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.L));

#line default
#line hidden
            EndContext();
            BeginContext(2536, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2598, 38, false);
#line 83 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.DisplayFor(model => model.L.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2636, 87, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <div class=\"alert alert-warning\" role=\"alert\">\r\n            ");
            EndContext();
            BeginContext(2724, 20, false);
#line 87 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
       Write(Html.Raw(Model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(2744, 50, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2794, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f90f5ec0bee3201340398140e613b0983936360413117", async() => {
                BeginContext(2840, 4, true);
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
#line 93 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
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
            BeginContext(2848, 53, true);
            WriteLiteral(" |\r\n\r\n</div>\r\n\r\n<div>\r\n    <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2901, "\"", 2948, 2);
            WriteAttributeValue("", 2908, "/Contents/Index?websiteId=", 2908, 26, true);
#line 98 "D:\IBS\NEW@_CMS\CMS-SYSTEM\Views\Contents\Details.cshtml"
WriteAttributeValue("", 2934, ViewBag.WebId, 2934, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2949, 27, true);
            WriteLiteral(">Back to List</a>\r\n</div>\r\n");
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
