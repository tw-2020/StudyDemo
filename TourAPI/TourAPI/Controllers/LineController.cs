using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourAPI.Models;

namespace TourAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LineController : Controller
    {
         /// <summary>
        /// 获取所有景点详情
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Line> GetAllLine()
        {
            List<Line> Lines = null;
            using (TourContext db = new TourContext())
            {
                Lines = db.Line.ToList();
            }
            return Lines;
        }
        /// <summary>
        /// 添加新的景点详情
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public int CreateLine(Line Line)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                db.Line.Add(Line);
                i = db.SaveChanges();
            }
            return i;
        }
        /// <summary>
        /// 根据id查找景点详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Line GetLineById(int id)
        {
            Line Line = null;
            using (TourContext db = new TourContext())
            {
                Line = db.Line.FirstOrDefault(t => t.LineId == id);
            }
            return Line;
        }
        /// <summary>
        /// 编辑景点详情
        /// </summary>
        /// <param name="Line"></param>
        /// <returns></returns>
        [HttpPost]
        public int EditLine(Line Line)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                db.Entry(Line).State = EntityState.Modified;
                i = db.SaveChanges();
            }
            return i;
        }
        /// <summary>
        /// 根据id删除景点详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public int DeleteLineById(int id)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                Line student = db.Line.Find(id);
                db.Line.Remove(student);
                db.SaveChanges();
            }
            return i;
        }
    }
}
