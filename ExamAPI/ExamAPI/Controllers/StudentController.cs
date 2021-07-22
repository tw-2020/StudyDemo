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
    public class StudentController : Controller
    {
        /// <summary>
        ///  学生登录
        /// </summary>
        /// <returns> 学生实体 </returns>
        [HttpPost]
        public Student Login(StudentLoginViewModel studentLoginViewModel)
        {
            Student student = null;
            using (ExamContext db = new ExamContext())
            {
                student = db.Student.FirstOrDefault(t =>
                t.StuLoginName == studentLoginViewModel.StuLoginName &&
                t.StuLoginPwd == studentLoginViewModel.StuLoginPwd);
            }
            return student;
        }

        /// <summary>
        /// 获取学生列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            List<Student> students = null;
            using (ExamContext db = new ExamContext())
            {
                students = db.Student.ToList();
            }
            return students;
        }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost]
        public int CreateStudent(Student student)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Student.Add(student);
                i = db.SaveChanges();
            }
            return i;
        }

        /// <summary>
        /// 编辑学生
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost]
        public int EditStudent(Student student)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Entry(student).State = EntityState.Modified;
                i = db.SaveChanges();   
            }
            return i;
        }


        /// <summary>
        /// 获取学生详情信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Student DetailStudents(int id)
        {
            Student student = null;
            using (ExamContext db = new ExamContext())
            {
                student = db.Student.FirstOrDefault(t=>t.StuID ==id);
            }
            return student;
        }

        /// <summary>
        /// 删除学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public int DeleteStudent(int id)
        {
            int  i = 0;
            using (ExamContext db = new ExamContext())
            {
                Student student = db.Student.Find(id);
                Console.WriteLine(student.StuName);
                db.Student.Remove(student);
                db.SaveChanges();
            }
            return i;
        }
    }
}

