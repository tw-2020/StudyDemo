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
    public class LineTypeController : Controller
    {
        /// <summary>
        /// 获取所有旅游线路
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<LineType> GetAllLine()
        {
            List<LineType> lineTypes = null;
            using (TourContext db = new TourContext())
            {
                lineTypes = db.LineType.ToList();
            }
            return lineTypes;
        }
        /// <summary>
        /// 添加新的旅游路线
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public int CreateLineType(LineType lineType)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                db.LineType.Add(lineType);
                i = db.SaveChanges();
            }
            return i;
        }
        /// <summary>
        /// 根据id查找路线
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public LineType GetLineTypeById(int id)
        {
            LineType lineType = null;
            using (TourContext db = new TourContext())
            {
                lineType = db.LineType.FirstOrDefault(t => t.LineTypeId == id);
            }
            return lineType;
        }
        /// <summary>
        /// 编辑路线
        /// </summary>
        /// <param name="lineType"></param>
        /// <returns></returns>
        [HttpPost]
        public int EditLineType(LineType lineType)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                db.Entry(lineType).State = EntityState.Modified;
                i = db.SaveChanges();
            }
            return i;
        }
        /// <summary>
        /// 根据id删除线路
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public int DeleteLineTypeById(int id)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                LineType student = db.LineType.Find(id);
                db.LineType.Remove(student);
                db.SaveChanges();
            }
            return i;
        }
    }
}
