using ExamUI.Common;
using ExamUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamUI.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Student/GetStudents");
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(result);
            return View(students);
        }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Student/CreateStudent", student);
                return RedirectToAction("Index");
            }
            return View();
        }

        /// <summary>
        /// 修改学生
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(int? id)
        {
            String result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Student/DetailStudents/"+ id);
            Student student = JsonConvert.DeserializeObject<Student>(result);
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            Console.WriteLine(student.StuEmail);
            String result =  HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Student/EditStudent", student);
            return RedirectToAction("Index");
        }


        /// <summary>
        /// 学生详情
        /// </summary>
        /// <returns></returns>
        public ActionResult Details(int? id)
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Student/DetailStudents/"+ id);
            Student student = JsonConvert.DeserializeObject<Student>(result);
            return View(student);
        }

        /// <summary>
        /// 删除学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int? id)
        {
            String result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Student/DetailStudents/" + id);
            Student student = JsonConvert.DeserializeObject<Student>(result);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Student/DeleteStudent/" + id, null);
            return RedirectToAction("index");
        }
    }
}
