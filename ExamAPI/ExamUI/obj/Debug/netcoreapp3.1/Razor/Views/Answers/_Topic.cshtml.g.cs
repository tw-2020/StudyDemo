#pragma checksum "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0cf3e9c5034dff40ef759f9654ba4a1ce85323c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Answers__Topic), @"mvc.1.0.view", @"/Views/Answers/_Topic.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
using ExamUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0cf3e9c5034dff40ef759f9654ba4a1ce85323c", @"/Views/Answers/_Topic.cshtml")]
    public class Views_Answers__Topic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamUI.Models.Detail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--当前页面分布式图-->\r\n");
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
  
    Answer answer = Model.Answer;
    string curanswer = Model.DetailAnswer;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>第 ");
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
 Write(ViewBag.sort);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 题 ");
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
                 Write(Model.Topic.TopicExplain);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 共 ");
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
                                             Write(ViewBag.count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 题</h3>\r\n");
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
Write(Html.HiddenFor(model => model.DetailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
Write(Html.HiddenFor(model => model.TopicId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
Write(Html.HiddenFor(model => model.AnswerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"hidden\" id=\"sort\" name=\"sort\"");
            BeginWriteAttribute("value", " value=\"", 396, "\"", 417, 1);
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
WriteAttributeValue("", 404, ViewBag.sort, 404, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"count\" name=\"count\"");
            BeginWriteAttribute("value", " value=\"", 467, "\"", 489, 1);
#nullable restore
#line 14 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
WriteAttributeValue("", 475, ViewBag.count, 475, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
 if (Model.Topic.TopicType == 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--选择题-->\r\n    <ul>\r\n");
#nullable restore
#line 18 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
         if (Model.Topic.TopicType == 1)
        {
            if (curanswer == "A")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 22 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
               Write(Html.RadioButtonFor(model => model.DetailAnswer, "A", new { @checked = "checked" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" A. ");
#nullable restore
#line 22 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
                                                                                                       Write(Model.Topic.TopicA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 26 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
               Write(Html.RadioButtonFor(model => model.DetailAnswer, "A"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" A. ");
#nullable restore
#line 26 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
                                                                         Write(Model.Topic.TopicA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 27 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
            }
            if (curanswer == "B")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 30 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
               Write(Html.RadioButtonFor(model => model.DetailAnswer, "B", new { @checked = "checked" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" B. ");
#nullable restore
#line 30 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
                                                                                                       Write(Model.Topic.TopicB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 31 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 34 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
               Write(Html.RadioButtonFor(model => model.DetailAnswer, "B"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" B. ");
#nullable restore
#line 34 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
                                                                         Write(Model.Topic.TopicB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 35 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
            }
            if (curanswer == "C")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 38 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
               Write(Html.RadioButtonFor(model => model.DetailAnswer, "C", new { @checked = "checked" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" C. ");
#nullable restore
#line 38 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
                                                                                                       Write(Model.Topic.TopicC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 39 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 42 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
               Write(Html.RadioButtonFor(model => model.DetailAnswer, "C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" C. ");
#nullable restore
#line 42 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
                                                                         Write(Model.Topic.TopicC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 43 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
            }
            if (curanswer == "D")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 46 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
               Write(Html.RadioButtonFor(model => model.DetailAnswer, "D", new { @checked = "checked" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" D. ");
#nullable restore
#line 46 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
                                                                                                       Write(Model.Topic.TopicD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 47 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 50 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
               Write(Html.RadioButtonFor(model => model.DetailAnswer, "D"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" D. ");
#nullable restore
#line 50 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
                                                                         Write(Model.Topic.TopicD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 51 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 54 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
 if (Model.Topic.TopicType == 2)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 59 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
         if (curanswer == "1")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 61 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
           Write(Html.RadioButtonFor(model => model.DetailAnswer, 1, new { @checked = "checked" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 正确 </li>\r\n            <li>");
#nullable restore
#line 62 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
           Write(Html.RadioButtonFor(model => model.DetailAnswer, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 错误</li>\r\n");
#nullable restore
#line 63 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
        }
        else if (curanswer == "0")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 66 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
           Write(Html.RadioButtonFor(model => model.DetailAnswer, 1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 正确</li>\r\n            <li>");
#nullable restore
#line 67 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
           Write(Html.RadioButtonFor(model => model.DetailAnswer, 0, new { @checked = "checked" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 错误</li>\r\n");
#nullable restore
#line 68 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 71 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
           Write(Html.RadioButtonFor(model => model.DetailAnswer, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 错误</li>\r\n            <li>");
#nullable restore
#line 72 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
           Write(Html.RadioButtonFor(model => model.DetailAnswer, 1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 正确</li>\r\n");
#nullable restore
#line 73 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 75 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
 if (Model.Topic.TopicType == 3)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul><li>");
#nullable restore
#line 79 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
       Write(Html.TextAreaFor(model => model.DetailAnswer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li></ul>\r\n");
#nullable restore
#line 80 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Answers\_Topic.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-offset-2 col-md-10\">\r\n\r\n    <input type=\"submit\" value=\"提交\" class=\"btn-default\" />\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamUI.Models.Detail> Html { get; private set; }
    }
}
#pragma warning restore 1591
