#pragma checksum "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b649727a6ad49a295f970ad7054e50facbbb695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b649727a6ad49a295f970ad7054e50facbbb695", @"/Views/Student/Index.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExamUI.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
  
    ViewBag.Title = "学生列表";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>学生列表</h2>\r\n<p>\r\n    ");
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
Write(Html.ActionLink("添加新的学生","Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(Model =>Model.StuName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(Model =>Model.StuLoginName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(Model => Model.StuLoginPwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(Model => Model.StuSex));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(Model => Model.StuPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(Model => Model.StuEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(Model => Model.StuGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
     foreach (var item in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
   Write(Html.DisplayFor(modelitem => item.StuName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
   Write(Html.DisplayFor(modelitem => item.StuLoginName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
   Write(Html.DisplayFor(modelitem => item.StuLoginPwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
    Write(item.StuSex?"男":"女");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
   Write(Html.DisplayFor(modelitem => item.StuPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
   Write(Html.DisplayFor(modelitem => item.StuEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
   Write(Html.DisplayFor(modelitem => item.StuGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 30 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
   Write(Html.ActionLink("编辑", "Edit", new { id = item.StuID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 31 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
   Write(Html.ActionLink("详情", "Details", new { id = item.StuID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
   Write(Html.ActionLink("删除", "Delete", new { id = item.StuID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 34 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Student\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExamUI.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
