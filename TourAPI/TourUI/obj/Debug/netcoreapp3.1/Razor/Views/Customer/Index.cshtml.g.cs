#pragma checksum "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c10697aba060da0fa7580ac7b80a79c10857292f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10697aba060da0fa7580ac7b80a79c10857292f", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde8bbaaec2d13013d289c023a90c99dbeb28d17", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TourUI.Models.Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/UI/jquery-1.7.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/UI/jquery.unobtrusive-ajax.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "列表页面";
    Layout = "~/Views/Shared/_Layout01.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Side Navbar -->


    <section>
        <div id=""page"" class=""container-fluid"">
            <!--Page Header-->
            <header>
                <h1 class=""h3 display"">
                    <a href=""#"" onclick=""createCustomer()"">创建客户</a>
                </h1>
            </header>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>客户列表</h4>
                        </div>
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-striped table-hover"">
                                    <thead>
                                        <tr>
                                            <th>客户姓名</th>
                                            <th>客户年龄</th>
                                            <th>客户身份证号</th>
                          ");
            WriteLiteral("                  <th>客户电话</th>\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Customer\Index.cshtml"
                                         foreach (TourUI.Models.Customer customer in ViewBag.Customers)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <th scope=\"row\"> ");
#nullable restore
#line 38 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Customer\Index.cshtml"
                                                            Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th scope=\"row\"> ");
#nullable restore
#line 39 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Customer\Index.cshtml"
                                                            Write(customer.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th scope=\"row\"> ");
#nullable restore
#line 40 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Customer\Index.cshtml"
                                                            Write(customer.IdentityId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th scope=\"row\"> ");
#nullable restore
#line 41 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Customer\Index.cshtml"
                                                            Write(customer.TEL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <td>\r\n                                                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2002, "\"", 2038, 3);
            WriteAttributeValue("", 2012, "edit(", 2012, 5, true);
#nullable restore
#line 43 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Customer\Index.cshtml"
WriteAttributeValue("", 2017, customer.CustomerId, 2017, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2037, ")", 2037, 1, true);
            EndWriteAttribute();
            WriteLiteral(">编辑</a> |\r\n                                                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2113, "\"", 2151, 3);
            WriteAttributeValue("", 2123, "detail(", 2123, 7, true);
#nullable restore
#line 44 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Customer\Index.cshtml"
WriteAttributeValue("", 2130, customer.CustomerId, 2130, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2150, ")", 2150, 1, true);
            EndWriteAttribute();
            WriteLiteral(">详细</a> |\r\n                                                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2226, "\"", 2265, 3);
            WriteAttributeValue("", 2236, "deletes(", 2236, 8, true);
#nullable restore
#line 45 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Customer\Index.cshtml"
WriteAttributeValue("", 2244, customer.CustomerId, 2244, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2264, ")", 2264, 1, true);
            EndWriteAttribute();
            WriteLiteral(">删除</a>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\Administrator\source\repos\TourAPI\TourUI\Views\Customer\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>



");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c10697aba060da0fa7580ac7b80a79c10857292f9236", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c10697aba060da0fa7580ac7b80a79c10857292f10275", async() => {
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
            WriteLiteral(@"

<script type=""text/javascript"">
    //添加客户
    function createCustomer() {
        var url = '/Customer/create';
        $.get(url, function (data) {
            $(""#page"").html(data);
        })
    }
    //退回到首页面
    function customer() {
        var url = '/Home/Index';
        $.get(url, function (data) {
            $(""#page"").html(data);
        })
    }
    //修改客户信息
    function edit(id) {
        var url = '/Customer/edit/' + id;
        $.get(url, function (data) {
            $(""#page"").html(data);
        })
    }

    //客户详情信息
    function detail(id) {
        var url = '/Customer/detail/' + id;
        $.get(url, function (data) {
            $(""#page"").html(data);
        })
    }

    //删除客户信息
    function deletes(id) {
        var url = '/Customer/delete/' + id;
        $.get(url, function (data) {
            $(""#page"").html(data);
        })
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TourUI.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
