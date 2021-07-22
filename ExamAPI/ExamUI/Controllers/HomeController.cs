using ExamUI.Common;
using ExamUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 学生登录
        public ActionResult LoginStudent()
        {
            return View();
        }

        //老师登录
        public ActionResult LoginTeacher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginStudent(string StuLoginName, string StuLoginPwd)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Student/Login",
                new
                {
                    StuLoginName = StuLoginName,
                    StuLoginPwd = StuLoginPwd
                });
            Student student = JsonConvert.DeserializeObject<Student>(result);
            if (student != null)
            {
                /*HttpContext.Session.SetInt32("LoginID", student.StuID);
                HttpContext.Session.SetString("LoginName", student.StuName);
                HttpContext.Session.SetString("Type", "学生");*/
                
                ViewBag.LoginID = student.StuID;
                ViewBag.LoginName = student.StuName;
                ViewBag.Type = "学生";

                TempData["LoginID"] = student.StuID;
                TempData["LoginName"] = student.StuName;
                TempData["Type"] = "学生";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "学生帐号或密码错误!");
            return View();
        }

        [HttpPost]
        public ActionResult LoginTeacher(string TeacherLoginName, string TeacherLoginPwd)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Teacher/Login",
                new
                {
                    TeacherLoginName = TeacherLoginName,
                    TeacherLoginPwd = TeacherLoginPwd
                });
            Teacher teacher = JsonConvert.DeserializeObject<Teacher>(result);
            if (teacher != null)
            {
                HttpContext.Session.SetInt32("LoginID", teacher.TeacherID);
                HttpContext.Session.SetString("LoginName", teacher.TeacherName);
                HttpContext.Session.SetString("Type", "老师");

                TempData["LoginID"] = teacher.TeacherID;
                TempData["LoginName"] = teacher.TeacherName;
                TempData["Type"] = "老师";

                ViewBag.LoginID = teacher.TeacherID;
                ViewBag.LoginName = teacher.TeacherName;
                ViewBag.Type = "老师";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "老师帐号或密码错误!");
            return View();
        }

        //退出登录
        public IActionResult Logout()
        {
            TempData["LoginID"] = null;
            TempData["LoginName"] = null;
            TempData["Type"] = null;

            return RedirectToAction("Index");
        }

    }
}
