using ExamApi.Models;
using ExamApi.ViewModels;
using ExamAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExamApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherController : Controller
    {
        /// <summary>
        ///  老师登录
        /// </summary>
        /// <returns> 老师实体 </returns>
        [HttpPost]
        public Teacher Login(TeacherLoginViewModel TeacherLoginViewModel)
        {
            Teacher teacher = null;
            using (ExamContext db = new ExamContext())
            {
                teacher = db.Teacher.FirstOrDefault(t =>
                t.TeacherLoginName == TeacherLoginViewModel.TeacherLoginName &&
                t.TeacherLoginPwd == TeacherLoginViewModel.TeacherLoginPwd);
            }
            return teacher;
        }

        /// <summary>
        /// 获取老师列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Teacher> GetTeachers()
        {
            List<Teacher> teachers = null;
            using (ExamContext db = new ExamContext())
            {
                teachers = db.Teacher.ToList();
            }
            return teachers;
        }

        /// <summary>
        /// 添加老师
        /// </summary>
        /// <param name="Teacher"></param>
        /// <returns></returns>
        [HttpPost]
        public int CreateTeacher(Teacher teacher)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Teacher.Add(teacher);
                i = db.SaveChanges();
            }
            return i;
        }

        /// <summary>
        /// 编辑老师
        /// </summary>
        /// <param name="Teacher"></param>
        /// <returns></returns>
        [HttpPost]
        public int EditTeacher(Teacher teacher)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Entry(teacher).State = EntityState.Modified;
                i = db.SaveChanges();
            }
            return i;
        }


        /// <summary>
        /// 获取老师详情信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Teacher DetailTeachers(int id)
        {
            Teacher teacher = null;
            using (ExamContext db = new ExamContext())
            {
                teacher = db.Teacher.Find(id);
            }
            return teacher;
        }

        /// <summary>
        /// 删除老师
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public int DeleteTeacher(int id)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                Teacher teacher = db.Teacher.Find(id);
                Console.WriteLine(teacher.TeacherName);
                db.Teacher.Remove(teacher);
                db.SaveChanges();
            }
            return i;
        }
    }
}
