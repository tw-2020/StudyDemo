#pragma checksum "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee21c13945c1d49840b9999e0ac0cd4f4b7a4982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Answers_TeAnswer), @"mvc.1.0.view", @"/Views/Answers/TeAnswer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee21c13945c1d49840b9999e0ac0cd4f4b7a4982", @"/Views/Answers/TeAnswer.cshtml")]
    public class Views_Answers_TeAnswer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExamUI.Models.Answer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
  
    ViewBag.Title = "我的考试";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>我的考试</h2>
<table class=""table"">
    <tr>
        <th>
            学生姓名
        </th>
        <th>
            试卷
        </th>
        <th>
            批卷
        </th>
        <th>
            分数
        </th>
        <th>
            操作
        </th>
    </tr>
");
#nullable restore
#line 27 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Student.StuName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Paper.PaperName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
            Write(item.AnswerState == 0 ? "答题中" : item.AnswerState == 1 ? "未批卷":"已批卷");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnswerScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
                 if (item.AnswerState == 1)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
               Write(Html.ActionLink("审卷", "Te", new { controller = "Answers", item.AnswerID }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
                                                                                               
                }
                else if (item.AnswerState == 2)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
               Write(Html.ActionLink("查看详情", "Te", new { controller = "Answers", item.AnswerID }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
                                                                                                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\TeAnswer.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExamUI.Models.Answer>> Html { get; private set; }
    }
}
#pragma warning restore 1591