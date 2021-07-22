

using ExamUI.Common;
using ExamUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamUI.Controllers
{
    public class PapersController : Controller
    {
        public IActionResult Index()
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Paper/GetPapers");
            List<Paper> papers = JsonConvert.DeserializeObject<List<Paper>>(result);
            return View(papers);
        }

        /// <summary>
        /// 添加试卷
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Paper paper)
        {
            if (ModelState.IsValid)
            {
                HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Paper/CreatePaper", paper);
                return RedirectToAction("Index");
            }
            return View();
        }

        /// <summary>
        /// 编辑试卷
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(int? id)
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Paper/DetailPapers/" + id);
            Paper paper = JsonConvert.DeserializeObject<Paper>(result);
            return View(paper);
        }

        [HttpPost]
        public ActionResult Edit(Paper paper)
        {
            if (ModelState.IsValid)
            {
                string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Paper/EditPaper", paper);
                return RedirectToAction("Index");
            }
            return View();
        }

        /// <summary>
        /// 删除试卷
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int? id)
        {
            String result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Paper/DetailPapers/" + id);
            Paper paper = JsonConvert.DeserializeObject<Paper>(result);
            if (paper == null)
            {
                return NotFound();
            }
            return View(paper);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Paper/DeletePaper/" + id, null);
            return RedirectToAction("index");
        }

        /// <summary>
        /// 在线考试编辑页面
        /// </summary>
        /// <returns></returns>
        public ActionResult IndexStu()
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Paper/GetPapers");
            List<Paper> papers = JsonConvert.DeserializeObject<List<Paper>>(result);
            return View(papers);
        }

        /// <summary>
        /// 开始答题
        /// </summary>
        /// <param name="PaperID"></param>
        /// <param name="AnswerID"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult BeginAnswer(int PaperID, int? AnswerID)
        {
            TempData.Keep("LoginID");
            TempData.Keep("LoginName");
            TempData.Keep("Type");

            if (AnswerID == null)//开始新的考试
            {
                Answer answer = new Answer();

                #region 初始化添加到数据

                answer.PaperID = PaperID;
                answer.StuID = (int)TempData["LoginID"];
                answer.TeacherID = 1;
                answer.AnswerTime = System.DateTime.Now;
                answer.AnswerState = 0;
                answer.AnswerScore = 0;
                string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Answers/CreateAnswer" , answer);
                answer.AnswerID = JsonConvert.DeserializeObject<int>(result);
                #endregion

                return RedirectToAction("AnswerDetail", new { id = answer.AnswerID });//打开答题试卷
            }
            else
            {
                return RedirectToAction("AnswerDetail", new { id = AnswerID });//打开答题试卷
            }

        }

        public ActionResult AnswerDetail(int id)
        {
            TempData.Keep("LoginID");
            TempData.Keep("LoginName");
            TempData.Keep("Type");

            int i = (int)TempData["LoginID"];
            int StuID = i;

            //获取刚刚新创建的Answer
            string answersResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetAnswer/" + id);
            Answer answer = JsonConvert.DeserializeObject<Answer>(answersResult);

            //获取登录学生信息
            string resultStu = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Student/DetailStudents/" + StuID);
            Student student = JsonConvert.DeserializeObject<Student>(resultStu);
            answer.Student = student;

            //获取考试试卷信息
            var paperID = answer.PaperID;
            string resultPap = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Paper/DetailPapers/" + paperID);
            Paper paper = JsonConvert.DeserializeObject<Paper>(resultPap);
            answer.Paper = paper;

            //获取试卷所有试题信息
            string topicResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Topic/GetTopics/" + answer.Paper.PaperID);
            List<Topic> topics = JsonConvert.DeserializeObject<List<Topic>>(topicResult);
            answer.Paper.Topic = topics;

            ViewBag.answer = answer;

            //将赋值的试卷信息传递到考试页面
            return View(answer);
        }


        /// <summary>
        /// 添加考题
        /// </summary>
        /// <param name="PaperId"></param>
        /// <returns></returns>
        public ActionResult Add(int? PaperId)
        {
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem() { Text = "单选", Value = "1" });
            li.Add(new SelectListItem() { Text = "判断", Value = "2" });
            li.Add(new SelectListItem() { Text = "填空", Value = "3" });

            ViewBag.Type = li;

            return View();
        }

        [HttpPost]
        public ActionResult Add(Topic topic)
        {
            TempData.Keep("LoginID");
            TempData.Keep("LoginName");
            TempData.Keep("Type");

            if (ModelState.IsValid)
            {
                string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Topic/CreateTopic", topic);
                int i = JsonConvert.DeserializeObject<int>(result);
                if (i != 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "添加失败!");
                }  
            }
                return View();
                  
        }

        /// <summary>
        /// 考题详情
        /// </summary>
        public ActionResult Details(int PaperId)
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Topic/GetTopics/" + PaperId);
            List<Topic> topics = JsonConvert.DeserializeObject<List<Topic>>(result);

            string resultPap = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Paper/DetailPapers/" + PaperId);
            Paper paper = JsonConvert.DeserializeObject<Paper>(resultPap);

            ViewBag.Paper = paper;

            return View(topics);
        }

        /// <summary>
        /// 删除试题
        /// </summary>
        /// <param name="TopicId"></param>
        /// <param name="PaperId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult DeleteTopic(int TopicId, int PaperId)
        {
            /*string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Topic/DeleteTopic/" + TopicId, null);
            return RedirectToAction("Details", new { PaperId });*/
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Topic/GetTopicEntity/" + TopicId);
            Topic topic = JsonConvert.DeserializeObject<Topic>(result);
            return View(topic);
        }

        [HttpPost, ActionName("DeleteTopic")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteTopicConfirmed(int TopicId,int PaperId)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Topic/DeleteTopic/" + TopicId, null);
            return RedirectToAction("Details", new { PaperId });
        }


        /// <summary>
        /// 修改试题
        /// </summary>
        /// <param name="TopicId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult UpdateTopic(int TopicId)
        {
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem() { Text = "单选", Value = "1" });
            li.Add(new SelectListItem() { Text = "判断", Value = "2" });
            li.Add(new SelectListItem() { Text = "填空", Value = "3" });

            ViewBag.Type = li;
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Topic/GetTopicEntity/" + TopicId);
            Topic topic = JsonConvert.DeserializeObject<Topic>(result);
            return View(topic);
        }

        [HttpPost]
        public ActionResult UpdateTopic(Topic topic)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Topic/SaveTopic", topic);
            return RedirectToAction("Detailed", new { topic.PaperId });
        }


    }
}
