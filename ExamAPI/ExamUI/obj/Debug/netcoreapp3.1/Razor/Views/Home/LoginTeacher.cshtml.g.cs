#pragma checksum "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ef6f41c42a0e3956b38ac06125928db9c89ccfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LoginTeacher), @"mvc.1.0.view", @"/Views/Home/LoginTeacher.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ef6f41c42a0e3956b38ac06125928db9c89ccfe", @"/Views/Home/LoginTeacher.cshtml")]
    public class Views_Home_LoginTeacher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamUI.Models.Teacher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml"
  
    ViewBag.Title = "老师登录";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>老师登录</h2>\r\n");
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml"
       Write(Html.LabelFor(model => model.TeacherLoginName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 16 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml"
           Write(Html.EditorFor(model => model.TeacherLoginName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 17 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml"
           Write(Html.ValidationMessageFor(model => model.TeacherLoginName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml"
       Write(Html.LabelFor(model => model.TeacherLoginPwd, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml"
           Write(Html.PasswordFor(model => model.TeacherLoginPwd, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml"
           Write(Html.ValidationMessageFor(model => model.TeacherLoginPwd, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\" 登录 \" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\Administrator\source\repos\ExamAPI\ExamUI\Views\Home\LoginTeacher.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamUI.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591