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
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Teacher/GetTeachers");
            List<Teacher> teachers = JsonConvert.DeserializeObject<List<Teacher>>(result);
            return View(teachers);
        }

        /// <summary>
        /// 添加老师
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Teacher/CreateTeacher", teacher);
                return RedirectToAction("Index");
            }
            return View();
          
        }

        /// <summary>
        /// 修改老师
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(int? id)
        {
            String result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Teacher/DetailTeachers/" + id);
            Teacher teacher = JsonConvert.DeserializeObject<Teacher>(result);
            return View(teacher);
        }

        [HttpPost]
        public ActionResult Edit(Teacher teacher)
        {
            Console.WriteLine(teacher.TeacherEmail);
            String result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Teacher/EditTeacher", teacher);
            return RedirectToAction("Index");
        }


        /// <summary>
        /// 老师详情
        /// </summary>
        /// <returns></returns>
        public ActionResult Details(int? id)
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Teacher/DetailTeachers/" + id);
            Teacher teacher = JsonConvert.DeserializeObject<Teacher>(result);
            return View(teacher);
        }

        /// <summary>
        /// 删除老师
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int? id)
        {
            String result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Teacher/DetailTeachers/" + id);
            Teacher teacher = JsonConvert.DeserializeObject<Teacher>(result);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Teacher/DeleteTeacher/" + id, null);
            return RedirectToAction("index");
        }
    }
}
