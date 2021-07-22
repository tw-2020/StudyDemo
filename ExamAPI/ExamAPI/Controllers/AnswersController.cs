using ExamApi.Models;
using ExamAPI.Models;
using ExamUI.Models;
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
    public class AnswersController : Controller
    {
        /// <summary>
        /// 根据id获取当前答案列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("{StuId}")]
        public IEnumerable<Answer> GetAnswerByStuIdEntity(int StuId)
        {
            IEnumerable<Answer> answer = null;
            using (ExamContext db = new ExamContext())
            {
                answer = db.Answer.Where(a => a.StuID == StuId).ToList();
            }
            return answer;
        }

        /// <summary>
        /// 根据试卷id获取Paper
        /// </summary>
        /// <param name="PaperId"></param>
        /// <returns></returns>
        [HttpGet("{PaperId}")]
        public Answer GetAnswerPap(int PaperId)
        {
            Answer answers = null;
            using (ExamContext db = new ExamContext())
            {

                answers = db.Answer.FirstOrDefault(p => p.PaperID == PaperId);
            }
            return answers;
        }

        /// <summary>
        /// 根据answerId获取答案信息
        /// </summary>
        /// <param name="AnswerId"></param>
        /// <returns></returns>
        [HttpGet("{AnswerId}")]
        public Answer GetAnswer(int AnswerId)
        {
            Answer answers = null;
            using (ExamContext db = new ExamContext())
            {

                answers = db.Answer.FirstOrDefault(p => p.AnswerID == AnswerId);
            }
            return answers;
        }

        /// <summary>
        /// 根据answerId获取所有的答题信息
        /// </summary>
        /// <param name="AnswerId"></param>
        /// <returns></returns>
        [HttpGet("{AnswerId}")]
        public IEnumerable<Detail> GetDetail(int AnswerId)
        {
            List<Detail> details = null;
            using (ExamContext db = new ExamContext())
            {

                details = db.Detail.Where(a => a.AnswerID == AnswerId).ToList();
            }
            return details;
        }

        /// <summary>
        /// 根据试题id获取试题
        /// </summary>
        /// <param name="TopicId"></param>
        /// <returns></returns>
        [HttpGet("{TopicId}")]
        public Topic GetTopic(int TopicId)
        {
            Topic topic = null;
            using (ExamContext db = new ExamContext())
            {

                topic = db.Topic.FirstOrDefault(p => p.TopicId == TopicId);
            }
            return topic;
        }

        /// <summary>
        /// 创建一个新的答题列表
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        [HttpPost]
        public int CreateAnswer(Answer answer)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Answer.Add(answer);
                i = db.SaveChanges();
            }
            return answer.AnswerID;
        }

        /// <summary>
        /// 修改回答
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        [HttpPost]
        public int UpdateDetail(Detail detail)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Entry(detail).State = EntityState.Modified;
                i = db.SaveChanges();
            }
            return i;
        }

        /// <summary>
        /// 修改答案
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        [HttpPost]
        public int UpdateAnswer(Answer answer)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Entry(answer).State = EntityState.Modified;
                i = db.SaveChanges();
            }
            return i;
        }

        /// <summary>
        /// 获取所有答案
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Answer> GetAllAnswer()
        {
            List<Answer> answers = null;
            using (ExamContext db = new ExamContext())
            {
                answers = db.Answer.ToList();
            }
            return answers;
        }
    }
}
