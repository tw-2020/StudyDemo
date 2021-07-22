#pragma checksum "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db6e1361909a915a1e34ec052a6f26d8655c464f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6e1361909a915a1e34ec052a6f26d8655c464f", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde8bbaaec2d13013d289c023a90c99dbeb28d17", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TourUI.Models.UserInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-left form-validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page login-page"">
    <div class=""container"">
        <div class=""form-outer text-center d-flex align-items-center"">
            <div class=""form-inner"">
                <div class=""logo text-uppercase"">
                    <span>天涯</span>
                    <strong class=""text-primary"">旅行</strong>
                </div>
                <p>良好的企业形象是一个企业的无形财产，企业员工的形象是企业形象的缩影，请求‘员工先做人后唱工’</p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db6e1361909a915a1e34ec052a6f26d8655c464f4570", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group-material\">\r\n                        ");
#nullable restore
#line 18 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.EditorFor(model => model.UserAccount, new { htmlAttributes = new { @class = "input-material" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 19 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(model => model.UserAccount, htmlAttributes: new { @class = "label-material" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(model => model.UserAccount, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group-material\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "input-material" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "label-material" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 25 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(model => model.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group-material\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.PasswordFor(model => model.UserPassword, htmlAttributes : new { @class = "input-material" } ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 29 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(model => model.UserPassword, htmlAttributes: new { @class = "label-material" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 30 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(model => model.UserPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group-material\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.EditorFor(model => model.UserPosition, new { htmlAttributes = new { @class = "input-material" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 34 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(model => model.UserPosition, htmlAttributes: new { @class = "label-material" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 35 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(model => model.UserPosition, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.DropDownListFor(model => model.UserGender, ViewBag.Gender as IEnumerable<SelectListItem>, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 39 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Home\Register.cshtml"
                   Write(Html.ValidationMessageFor(model => model.UserGender, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group text-center\">\r\n                        <input id=\"register\" type=\"submit\" value=\"注册\" class=\"btn btn-primary\">\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                <small>已经有一个账户了？ </small>
                <a href=""/Home/Index"" class=""signup"">登录</a>
            </div>
            <div class=""copyrights text-center"">
                <p>版权归XX公司所有@2018-2020</p>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TourUI.Models.UserInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
