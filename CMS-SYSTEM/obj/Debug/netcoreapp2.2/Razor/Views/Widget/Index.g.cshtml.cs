#pragma checksum "C:\Users\Donia\Documents\GitHub\IBS-CMS-Project\CMS-SYSTEM\Views\Widget\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f7c16dffc2b566219c98aacff5ffd1fde89ed09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Widget_Index), @"mvc.1.0.view", @"/Views/Widget/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Widget/Index.cshtml", typeof(AspNetCore.Views_Widget_Index))]
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
#line 1 "C:\Users\Donia\Documents\GitHub\IBS-CMS-Project\CMS-SYSTEM\Views\_ViewImports.cshtml"
using CMS_SYSTEM;

#line default
#line hidden
#line 2 "C:\Users\Donia\Documents\GitHub\IBS-CMS-Project\CMS-SYSTEM\Views\_ViewImports.cshtml"
using CMS_SYSTEM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7c16dffc2b566219c98aacff5ffd1fde89ed09", @"/Views/Widget/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"800befe70c00d8c944edbeff807e79a6362d136d", @"/Views/_ViewImports.cshtml")]
    public class Views_Widget_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 251, true);
            WriteLiteral("<button type=\"button\" id=\"btnAddd\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#addModal\"> Add </button>\r\n<br />\r\n<br />\r\n<table class=\"table table-striped text-center\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Title</th>\r\n");
            EndContext();
            BeginContext(298, 4459, true);
            WriteLiteral(@"            <th scope=""col"">Created Date</th>
            <th scope=""col"">Created By</th>
            <th scope=""col"">Updated Date</th>
            <th scope=""col"">Modified By</th>
            <th scope=""col"">Is Published</th>
            <th scope=""col"">Is Active</th>
            <th scope=""col"">Options</th>
        </tr>
    </thead>
    <tbody class=""MyTbody""></tbody>
</table>


<!--Model Add-->
<div class=""container mt-3"">
    <!-- The Modal -->
    <div class=""modal fade"" id=""addModal"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">

                <!-- Modal Header -->
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Add Widget</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
                </div>

                <!-- Modal body -->
                <div class=""modal-body"">

                    <div class=""form-group"">
                        <label class=""control");
            WriteLiteral(@"-label col-sm-2"" for=""wTitle"">Title:</label>
                        <div class=""col-sm-5"">
                            <input type=""text"" class=""form-control"" id=""title"" placeholder=""Title"" name=""title"">
                        </div>
                    </div>

                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-10"">
                                <label class=""control-label col-sm-2"" for=""wHtmlBody"">HTML:</label>

                                <textarea class=""editor"" name=""wHtmlBodyAdd"" id=""wHtmlBodyAdd""></textarea>

                            </div>
                        </div>
                    </div>

                    <hr />

                    <div class=""form-group"">
                        <div class=""col-sm-offset-2 col-sm-10"">
                            <button type=""submit"" id=""btnAdd"" class=""btn btn-success"">Add</button>
                        </div>
                    </div>
");
            WriteLiteral(@"
                </div>

                <!-- Modal footer -->
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                </div>

            </div>
        </div>
    </div>

</div>

<!--Model Edit-->
<div class=""container mt-3"">
    <!-- The Modal -->
    <div class=""modal fade"" id=""editModel"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">

                <!-- Modal Header -->
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Add Widget</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
                </div>

                <!-- Modal body -->
                <div class=""modal-body"">

                    <div class=""form-group"">
                        <label class=""control-label col-sm-2"" for=""wTitle"">Title:</label>
                        <div class=""col-sm-5"">
    ");
            WriteLiteral(@"                        <input type=""text"" class=""form-control"" id=""titleEdit"" placeholder=""Title"" name=""title"">
                        </div>
                    </div>

                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-10"">
                                <label class=""control-label col-sm-2"" for=""wHtmlBody"">HTML:</label>

                                <textarea class=""editor"" name=""wHtmlBodyEdit"" id=""wHtmlBodyEdit""></textarea>

                            </div>
                        </div>
                    </div>

                    <hr />

                    <div class=""form-group"">
                        <div class=""col-sm-offset-2 col-sm-10"">
                            <button type=""button"" id=""btnEdit"" class=""btn btn-success"">Save</button>
                        </div>
                    </div>

                </div>

                <!-- Modal footer -->
                <div cla");
            WriteLiteral(@"ss=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""currentId"" hidden id=""0""></button>
                </div>

            </div>
        </div>
    </div>

</div>

<textarea id=""editor"" placeholder=""Balabala"" autofocus></textarea>

");
            EndContext();
            BeginContext(4757, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f7c16dffc2b566219c98aacff5ffd1fde89ed099088", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4808, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4810, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f7c16dffc2b566219c98aacff5ffd1fde89ed0910267", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4856, 5091, true);
            WriteLiteral(@"



<script>
    var widgetID;
    AllWidgets();



    function AllWidgets() {
        $.get('/Widget/GetWidgets', function (data) {
            var s = """";
            $.each(data, function (i, v) {
                s += '<tr id=""' + v.id + '"">' +
                    '<td>' + v.title + '</td>' +
                    //'<td>' + v.htmlBody + '</td>' +
                    '<td>' + v.createdDate + '</td>' +
                    '<td>' + v.createdBy + '</td>' +
                    '<td>' + v.updatedDate + '</td>' +
                    '<td>' + v.updatedBy + '</td>' +
                    '<td>' + v.isPublished + '</td>' +
                    '<td>' + v.isActive + '</td>' +
                    '<td>' +
                    '<button type=""button"" id=""' + v.id + '"" class=""btn btn-warning"" data-toggle=""modal"" onclick=""GetWidget(id)"" data-target=""#editModel"">Edit</button>' +
                    ' | ' +
                    '<a href=""/widget/details?id=' + v.id + '"" class=""btn btn-primary"">View</a>");
            WriteLiteral(@"' +
                    //' | ' +
                    //'<a href=""/widget/edit?id=' + v.id + '"" class=""btn btn-warning"">Edit</a>' +
                    '</td>' +
                    '</tr>';
            });
            var tbody = $('.MyTbody');
            if (tbody != null) {
                tbody.html('');
            }
            $('.MyTbody').empty();
            $('.MyTbody').append(s);
        });
    }




    $(""#btnAdd"").click(function () {

        var htmlContent = CKEDITOR.instances.wHtmlBodyAdd.getData();
        //var widgetBody = $(""#wHtmlBody"").val();
        var title = $(""#title"").val();


        var obj = {
            'HtmlBody': htmlContent,
            'Title': title

        };
        var PostData = JSON.stringify(obj);
        $.ajax({
            type: 'post',
            dataType: 'json',
            data: PostData,
            contentType: 'application/json',
            url: ""/Widget/AddWidget"",
            success: function (data) {
      ");
            WriteLiteral(@"          if (data == true) {
                    alert(""Done"");
                    $('input').val('');
                    $('textarea').val('');
                    $('#addModal').modal('hide');
                    AllWidgets();
                }
                else {
                    alert(""Error !"");
                }
            },
            error: function () {
                alert(""Error !"");
                AllWidgets();
            }

        })

    });



    function GetWidget(id) {
        widgetID = id;

        $.ajax({
            type: 'Get',
            datatype: 'json',
            contentType: 'application/json',
            data: '',
            url: '/Widget/GetWidget/' + id,
            success: function (data) {
                $(""#titleEdit"").val(data.title);
                //CKEDITOR.instances.wHtmlBodyEdit.insertText(data.htmlBody);
                //CKEDITOR.instances.wHtmlBodyEdit.innerHtml(data.htmlBody);
                //CKEDITOR.inst");
            WriteLiteral(@"ances.wHtmlBodyEdit.getData(data.htmlBody);
                //CKEDITOR.instances.wHtmlBodyEdit.dataType.append(data.htmlBody);

            },
            error: function () {
                alert(""Error"");
            }
        });
    };

    $('#btnEdit').click(function () {
        var widgetId = widgetID;

        var htmlContent = CKEDITOR.instances.wHtmlBodyEdit.getData();
        var title = $(""#titleEdit"").val();

        var obj = {
            'HtmlBody': htmlContent,
            'Title': title
        };
        var dataPost = JSON.stringify(obj);
        $.ajax({
            type: 'Post',
            datatype: 'json',
            contentType: 'application/json',
            data: dataPost,
            url: '/Widget/EditWidget/' + widgetId,
            success: function (data) {
                if (data == true) {
                    alert(""Done"");
                    $('#editModel').modal('hide');
                    AllWidgets();

                }
            ");
            WriteLiteral(@"    else {
                    alert(""Error"");
                }
            },
            error: function () {
                alert(""Error"");
            }
        });
    });


    //function GetWidgetId(target) {
    //    var x = $(target).closest('button');
    //    var id = $(x).prop('id');
    //    $('.currentId').prop('id', id);

    //}













    //CKEDITOR.replace(""wHtmlBodyAdd"");
    //CKEDITOR.editorConfig = function (config) {
    //    // Define changes to default configuration here. For example:
    //    // config.language = 'fr';
    //    // config.uiColor = '#AADC6E';
    //    config.toolbar = 'Basic';
    //};

    //CKEDITOR.replace(""wHtmlBodyEdit"");
    //CKEDITOR.editorConfig = function (config) {
    //    // Define changes to default configuration here. For example:
    //    // config.language = 'fr';
    //    // config.uiColor = '#AADC6E';
    //    config.toolbar = 'Basic';
    //};
</script>

");
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
