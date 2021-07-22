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
    public class TopicController : Controller
    {

        /// <summary>
        /// 根据试卷id获取所有试题
        /// </summary>
        /// <param name="PaperId"></param>
        /// <returns></returns>
        [HttpGet("{PaperId}")]
        public IEnumerable<Topic> GetTopics(int PaperId)
        {
            List<Topic> topics = null;
            using (ExamContext db = new ExamContext())
            {
                // details = db.Detail.Where(a => a.AnswerID == AnswerId).ToList();
                topics = db.Topic.Where(a => a.PaperId == PaperId).ToList();
            }
            return topics;
        }

        /// <summary>
        /// 根据试题id获取单独试题
        /// </summary>
        /// <param name="TopicId"></param>
        /// <returns></returns>
        [HttpGet("{TopicId}")]
        public Topic GetTopicEntity(int TopicId)
        {
            Topic topic = null;
            using (ExamContext db = new ExamContext())
            {
                topic = db.Topic.FirstOrDefault(a => a.TopicId == TopicId);
            }
            return topic;
        }

        /// <summary>
        /// 创建新的试题
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        [HttpPost]
        public int CreateTopic(Topic topic)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Topic.Add(topic);
                i = db.SaveChanges();
            }
            return i;
        }

        /// <summary>
        /// 根据试卷id获取所有试题
        /// </summary>
        /// <param name="PaperId"></param>
        /// <returns></returns>
        [HttpGet("{PaperId}")]
        public IEnumerable<Topic> GetTopicsByPaperId(int PaperId)
        {
            List<Topic> topics = null;
            using (ExamContext db = new ExamContext())
            {
                topics = db.Topic.Where(a => a.PaperId == PaperId).ToList();
            }
            return topics;
        }

        /// <summary>
        /// 删除试题
        /// </summary>
        /// <param name="TopicId"></param>
        /// <returns></returns>
        [HttpPost("{TopicId}")]
        public int DeleteTopic(int TopicId)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                Topic topic = db.Topic.Find(TopicId);
                db.Topic.Remove(topic);
                db.SaveChanges();
            }
            return i;
        }
        
        /// <summary>
        /// 修改试题
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        [HttpPost]
        public int SaveTopic(Topic topic)
        {
            int i = 0;
            using (ExamContext db = new ExamContext())
            {
                db.Entry(topic).State = EntityState.Modified;
                i = db.SaveChanges();
            }
            return i;
        }
    }
}
