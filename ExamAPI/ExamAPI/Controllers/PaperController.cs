using ExamApi.Models;
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
    public class PaperController : Controller
    {  
        /// <summary>
        /// 获取试卷列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Paper> GetPapers()
        {
            List<Paper> papers = null;
            using (ExamContext db = new ExamContext())
            {
                papers = db.Paper.ToList();
            }
            return papers;
        }

        /// <summary>
        /// 添加试卷
        /// </summary>
        /// <param name="Paper"></param>
        /// <returns></returns>
        [HttpPost]
        public int CreatePaper(Paper paper)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Paper.Add(paper);
                i = db.SaveChanges();
            }
            return i;
        }

        /// <summary>
        /// 编辑试卷
        /// </summary>
        /// <param name="Paper"></param>
        /// <returns></returns>
        [HttpPost]
        public int EditPaper(Paper paper)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Entry(paper).State = EntityState.Modified;
                i = db.SaveChanges();
            }
            return i;
        }


        /// <summary>
        /// 获取试卷详情信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Paper DetailPapers(int id)
        {
            Paper paper = null;
            using (ExamContext db = new ExamContext())
            {
                paper = db.Paper.Find(id);
            }
            return paper;
        }

        /// <summary>
        /// 删除试卷
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public int DeletePaper(int id)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                Paper paper = db.Paper.Find(id);
                db.Paper.Remove(paper);
                db.SaveChanges();
            }
            return i;
        }
    }
}
