using ExamApi.Models;
using ExamAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DetailsController : Controller
    {
        /// <summary>
        /// 获取回答份数
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        [HttpPost]
        public int GetDetailsByCount(Detail detail)
        {
            List<Detail> details = null;
            using (ExamContext db = new ExamContext())
            {
                details = db.Detail.Where(a => a.AnswerID == detail.AnswerID && a.TopicID == detail.TopicID).ToList();
            }

            return details.Count;
        }

        /// <summary>
        /// 创建新的回答
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        [HttpPost]
        public int CreateDetail(Detail detail)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Detail.Add(detail);
                i = db.SaveChanges();
            }
            return i;
        }

        /// <summary>
        ///根据答案id获取回答
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        [HttpPost]
        public Detail GetDetails(Detail detail)
        {
            Detail details = null;
            using (ExamContext db = new ExamContext())
            {
                details = db.Detail.FirstOrDefault(a => a.AnswerID == detail.AnswerID && a.TopicID == detail.TopicID);
            }

            return details;
        }

        /// <summary>
        /// 根据ansewerId获取回答
        /// </summary>
        /// <param name="aid"></param>
        /// <returns></returns>
        [HttpGet("{aid}")]
        public IEnumerable<Detail> GetDetailsByAnswerId(int aid)
        {
            List<Detail> details = null;
            using (ExamContext db = new ExamContext())
            {
                details = db.Detail.Where(a => a.AnswerID == aid ).ToList();
            }

            return details;
        }

       
    }
}
