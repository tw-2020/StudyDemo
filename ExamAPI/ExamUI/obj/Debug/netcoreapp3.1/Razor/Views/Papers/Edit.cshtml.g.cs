#pragma checksum "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c900d3e04e02c4a856fae98f9caf57dc81f1a83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Papers_Edit), @"mvc.1.0.view", @"/Views/Papers/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c900d3e04e02c4a856fae98f9caf57dc81f1a83", @"/Views/Papers/Edit.cshtml")]
    public class Views_Papers_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamUI.Models.Paper>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Papers/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
  
    ViewBag.Title = "试卷详情";
    Layout = "~/Views/Shared/_layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>试卷详情</h2>\r\n<span><b>试卷信息</b></span>\r\n<hr />\r\n");
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
   Write(Html.LabelFor(model => model.PaperID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
       Write(Html.HiddenFor(model => model.PaperID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.PaperID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
   Write(Html.LabelFor(model => model.PaperName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
       Write(Html.EditorFor(model => model.PaperName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.PaperName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 29 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
   Write(Html.LabelFor(model => model.PaperExplain, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
       Write(Html.EditorFor(model => model.PaperExplain, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.PaperExplain, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 37 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
   Write(Html.LabelFor(model => model.PaperTime, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
       Write(Html.EditorFor(model => model.PaperTime, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 40 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.PaperTime, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\" 保存 \" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 50 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c900d3e04e02c4a856fae98f9caf57dc81f1a838018", async() => {
                WriteLiteral("返回试卷列表");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamUI.Models.Paper> Html { get; private set; }
    }
}
#pragma warning restore 1591
