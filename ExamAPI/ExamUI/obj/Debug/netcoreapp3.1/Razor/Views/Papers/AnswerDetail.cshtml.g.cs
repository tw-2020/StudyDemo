#pragma checksum "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d76daa0f21eb05d7e3d1fe11a90880bb603d2f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Papers_AnswerDetail), @"mvc.1.0.view", @"/Views/Papers/AnswerDetail.cshtml")]
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
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
using ExamUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d76daa0f21eb05d7e3d1fe11a90880bb603d2f6", @"/Views/Papers/AnswerDetail.cshtml")]
    public class Views_Papers_AnswerDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamUI.Models.Answer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--导入jquery需要的js和样式文件-->\r\n<script src=\"/UI/jquery-1.7.1.min.js\"></script>\r\n<script src=\"/UI/jquery.unobtrusive-ajax.min.js\"></script>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
   
    ViewBag.Title = "在线考试";
    Answer answer = (Answer)ViewBag.answer;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>在线考试</h2>\r\n<table>\r\n    <tr>\r\n        <td>\r\n            <h4>试卷描述</h4><hr />\r\n            ");
#nullable restore
#line 18 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Paper.PaperName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(Html.DisplayFor(model => model.Paper.PaperName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            ");
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Paper.PaperExplain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(Html.DisplayFor(model => model.Paper.PaperExplain));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            ");
#nullable restore
#line 22 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Paper.PaperTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(Html.DisplayFor(model => model.Paper.PaperTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        </td>\r\n        <td>\r\n            <h4>考生信息</h4>\r\n            ");
#nullable restore
#line 27 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Student.StuName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(Html.DisplayFor(model => model.Student.StuName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            ");
#nullable restore
#line 29 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Student.StuGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(Html.DisplayFor(model => model.Student.StuGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            ");
#nullable restore
#line 31 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(Html.ActionLink("交卷", "SubmitAnswer", new { controller = "Answers", Model.AnswerID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </td>
    </tr>
</table>

<fieldset>
    <legend>答题区</legend>
    <form action=""/Answers/SubmitDetail"" data-ajax=""true"" data-ajax-method=""Post"" data-ajax-mode=""replace"" data-ajax-update=""#topic"" id=""form0"" method=""post"">
        <div id=""topic"" style=""border:1px solid gray"">
            <!--展示所有考题序号链接-->
");
#nullable restore
#line 41 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
             for (int i = 1; i <= Model.Paper.Topic.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1670, "\"", 1705, 5);
            WriteAttributeValue("", 1680, "topic(", 1680, 6, true);
#nullable restore
#line 43 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
WriteAttributeValue("", 1686, Model.AnswerID, 1686, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1701, ",", 1701, 1, true);
#nullable restore
#line 43 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
WriteAttributeValue("", 1702, i, 1702, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1704, ")", 1704, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 44 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1753, "\"", 1791, 3);
            WriteAttributeValue("", 1763, "showAnswer(", 1763, 11, true);
#nullable restore
#line 45 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
WriteAttributeValue("", 1774, Model.AnswerID, 1774, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1789, ");", 1789, 2, true);
            EndWriteAttribute();
            WriteLiteral(">试卷内容</a>\r\n");
            WriteLiteral(@"        </div>
    </form>
</fieldset>

<script type=""text/javascript"">
    //按排序编号显示考题
    function topic(aid, sort) {
        var url = '/Answers/_Topic?aid=' + aid + '&sort=' + sort;
        $.get(url, function (data) {
            $(""#topic"").html(data);
        })
    }
    //显示所有考题
    function showAnswer(aid) {
        var url = '/Answers/_AllDetailStu?aid=' + aid;
        $.get(url, function (data) {
            $(""#topic"").html(data);
        })
    }

    //默认显示第一题
    $(topic(");
#nullable restore
#line 68 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Papers\AnswerDetail.cshtml"
       Write(answer.AnswerID);

#line default
#line hidden
#nullable disable
            WriteLiteral(",1))\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamUI.Models.Answer> Html { get; private set; }
    }
}
#pragma warning restore 1591
