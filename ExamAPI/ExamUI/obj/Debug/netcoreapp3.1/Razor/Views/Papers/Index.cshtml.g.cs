#pragma checksum "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "953121bc2fea95c5158937f36ea1d966f74ac76e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Papers_Index), @"mvc.1.0.view", @"/Views/Papers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"953121bc2fea95c5158937f36ea1d966f74ac76e", @"/Views/Papers/Index.cshtml")]
    public class Views_Papers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExamUI.Models.Paper>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
  
    ViewBag.Title = "试卷列表";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>试卷列表</h2>\r\n<p>\r\n    ");
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
Write(Html.ActionLink("添加新的试卷", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
       Write(Html.DisplayNameFor(Model => Model.PaperName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
       Write(Html.DisplayNameFor(Model => Model.PaperExplain));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
       Write(Html.DisplayNameFor(Model => Model.PaperTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
   Write(Html.DisplayFor(modelitem => item.PaperName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
   Write(Html.DisplayFor(modelitem => item.PaperExplain));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
   Write(Html.DisplayFor(modelitem => item.PaperTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
   Write(Html.ActionLink("添加考题", "Add", new { PaperId = item.PaperID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
   Write(Html.ActionLink("编辑", "Edit", new { id = item.PaperID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
   Write(Html.ActionLink("详情", "Details", new { PaperId = item.PaperID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
   Write(Html.ActionLink("删除", "Delete", new { id = item.PaperID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 28 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExamUI.Models.Paper>> Html { get; private set; }
    }
}
#pragma warning restore 1591
