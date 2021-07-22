
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
    public class AnswersController : Controller
    {

        //学生试卷列表
        public ActionResult MyAnswer()
        {

            int? sid = Convert.ToInt32(TempData.Peek("LoginID"));
            //根据id获取当前答案列表
            string papersResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetAnswerByStuIdEntity/" + sid);
            List<Answer> answers = JsonConvert.DeserializeObject<List<Answer>>(papersResult);
            //获取答题学生信息
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Student/DetailStudents/" + sid);
            Student student = JsonConvert.DeserializeObject<Student>(result);

            //将answer里的学生赋值
            answers.ForEach(m => m.Student = student);

            return View(answers);
        }

        //试卷详情
        public ActionResult MyAnswerDetails(int? AnswerId)
        {
            TempData.Keep("LoginID");
            int i= (int)TempData["LoginID"];
            int StuID = i;
            //获取答题信息
            string answersResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetAnswer/" + AnswerId);
            Answer answer = JsonConvert.DeserializeObject<Answer>(answersResult);
            //获取学生信息
            string resultStu = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Student/DetailStudents/" + StuID);
            Student student = JsonConvert.DeserializeObject<Student>(resultStu);
            answer.Student = student;

            //获取试卷详情信息
            var paperID = answer.PaperID;
            string resultPap = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Paper/DetailPapers/" + paperID);
            Paper paper = JsonConvert.DeserializeObject<Paper>(resultPap);
            answer.Paper = paper;

            //获取答题列表
            string detailResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetDetail/" + AnswerId);
            List<Detail> details = JsonConvert.DeserializeObject<List<Detail>>(detailResult);

            foreach (Detail detail in details)
            {
                var TopicId = detail.TopicId;
                string resultTop = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetTopic/" + TopicId);
                Topic topic = JsonConvert.DeserializeObject<Topic>(resultTop);
                detail.Topic = topic;

                detail.Answer = answer;
            }

            ViewBag.Details = details;

            return View(answer);
        }

        //答题试卷显示当前考题，返回部分视图
        public ActionResult _Topic(int aid,int? sort)
        {
            int cursort = sort == null ? 1 : (int)sort;//如果考题序号，显示第一题

            #region 处理过程
            string answerResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetAnswer/" + aid);
            Answer answer = JsonConvert.DeserializeObject<Answer>(answerResult);
            if (answer == null)
            {
                return NotFound();
            }
            
            string paperResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Paper/DetailPapers/" + answer.PaperID);
            var paper = JsonConvert.DeserializeObject<Paper>(paperResult);
            answer.Paper = paper;

            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Student/DetailStudents/" + answer.StuID);
            Student student = JsonConvert.DeserializeObject<Student>(result);
            answer.Student = student;

            string topicResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Topic/GetTopics/" + answer.Paper.PaperID);
            List<Topic> topics = JsonConvert.DeserializeObject<List<Topic>>(topicResult);
            answer.Paper.Topic = topics;

            ViewBag.answer = answer;
            //获取题目信息合集，获取当前题目
            Topic topic = answer.Paper.Topic.ToList()[cursort - 1];
            ViewBag.topic = topic;
            ViewBag.sort = cursort;
            ViewBag.count = answer.Paper.Topic.ToList().Count;
            //获取题目对应的答题信息
            Detail detail = new Detail
            {
                AnswerId = aid,
                TopicId = topic.TopicId
            };

            string countResult = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Details/GetDetailsByCount", detail);
            int count = JsonConvert.DeserializeObject<int>(countResult);

            if (count == 0)
            {
                //新建题目答案
                Detail detail1 = new Detail();
                detail1.AnswerId = answer.AnswerID;
                detail1.TopicId = topic.TopicId;
                detail1.DetailAnswer = "";
                string addResult = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Details/CreateDetail", detail1);
            }

            string detailResult = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Details/GetDetails", detail);
            Detail curDetail = JsonConvert.DeserializeObject<Detail>(detailResult);

            string answerResult2 = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetAnswer/" + curDetail.AnswerId);
            curDetail.Answer = JsonConvert.DeserializeObject<Answer>(answerResult2);

            string topicResult1 = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Topic/GetTopicEntity/" + curDetail.TopicId);
            curDetail.Topic = JsonConvert.DeserializeObject<Topic>(topicResult1);
            #endregion

            return PartialView(curDetail);
        }

        //答题显示所有考题，返回分布视图
        public ActionResult _AllDetailStu(int aid)
        {
            //显示全部答题信息
            #region 处理过程
            string detailResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Details/GetDetailsByAnswerId/" + aid);
            List<Detail> curdetails = JsonConvert.DeserializeObject<List<Detail>>(detailResult);
            foreach (Detail detail in curdetails)
            { 
                string topicResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL+"api/Topic/GetTopicEntity/"+detail.TopicId);
                detail.Topic = JsonConvert.DeserializeObject<Topic>(topicResult);

                string answerResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetAnswer/" + detail.AnswerId);
                detail.Answer = JsonConvert.DeserializeObject<Answer>(answerResult);
            }

            ViewBag.Details = curdetails;
            #endregion

            return PartialView();
        }

        /// <summary>
        /// 每题提交
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        public ActionResult SubmitDetail(Detail detail)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Answers/UpdateDetail", detail);
            int i = JsonConvert.DeserializeObject<int>(result);

            int sort = Convert.ToInt32(Request.Form["sort"].ToString()) + 1;
            int count = Convert.ToInt32(Request.Form["count"].ToString());
            //int sort = topic.TopicSort + 1;
            if (sort <= count)
                return RedirectToAction("_Topic", new { aid = detail.AnswerId, sort });
            else
                return RedirectToAction("_AllDetailStu", new { aid = detail.AnswerId, sort });
        }

        /// <summary>
        /// 提交考试试卷
        /// </summary>
        /// <returns></returns>
        public ActionResult SubmitAnswer(int AnswerId)
        {
            string answersResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetAnswer/" + AnswerId);
            Answer answer = JsonConvert.DeserializeObject<Answer>(answersResult);

            answer.AnswerState = 1;
            answer.SubmitTime = DateTime.Now;


            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Answers/UpdateAnswer", answer);
            int i = JsonConvert.DeserializeObject<int>(result);

            return RedirectToAction("MyAnswer");
        }


        /// <summary>
        /// 审卷
        /// </summary>
        /// <returns></returns>
        public ActionResult TeAnswer()
        {
            TempData.Keep("LoginID");
            TempData.Keep("LoginName");
            TempData.Keep("Type");
            string papersResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetAllAnswer");
            List<Answer> answers = JsonConvert.DeserializeObject<List<Answer>>(papersResult);

            foreach (Answer answer in answers)
            {
                var StuId = answer.StuID;
                string resultStu = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Student/DetailStudents/" + StuId);
                Student student = JsonConvert.DeserializeObject<Student>(resultStu);
                answer.Student = student;

                var PaperId = answer.PaperID;
                string resultPap = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Paper/DetailPapers/" + PaperId);
                Paper paper = JsonConvert.DeserializeObject<Paper>(resultPap);
                answer.Paper = paper;

            }
            return View(answers);
        }

        public ActionResult Te(int AnswerId)
        {
            TempData.Keep("LoginID");
            TempData.Keep("LoginName");
            TempData.Keep("Type");
            string answersResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetAnswer/" + AnswerId);
            Answer answer = JsonConvert.DeserializeObject<Answer>(answersResult);

            string resultStu = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Student/DetailStudents/" + answer.StuID);
            Student student = JsonConvert.DeserializeObject<Student>(resultStu);
            answer.Student = student;


            var PaperId = answer.PaperID;
            string resultPap = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Paper/DetailPapers/" + PaperId);
            Paper paper = JsonConvert.DeserializeObject<Paper>(resultPap);
            answer.Paper = paper;

            string detailResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetDetail/" + AnswerId);
            List<Detail> details = JsonConvert.DeserializeObject<List<Detail>>(detailResult);

            foreach (Detail detail in details)
            {
                var TopicId = detail.TopicId;
                string resultTop = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Topic/GetTopicEntity/" + TopicId);
                Topic topic = JsonConvert.DeserializeObject<Topic>(resultTop);
                detail.Topic = topic;

                detail.Answer = answer;
            }

            ViewBag.Details = details;


            return View(answer);

        }

        public ActionResult TeAn(int AnswerId, int Score)
        {
            TempData.Keep("LoginID");
            TempData.Keep("LoginName");
            TempData.Keep("Type");
            string answersResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Answers/GetAnswer/" + AnswerId);
            Answer answer = JsonConvert.DeserializeObject<Answer>(answersResult);

            answer.AnswerState = 2;
            answer.TeacherID= (int)TempData["LoginID"];
            answer.BatchTime = DateTime.Now;
            answer.AnswerScore = Score;


            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Answers/UpdateAnswer", answer);
            int i = JsonConvert.DeserializeObject<int>(result);

            return RedirectToAction("TeAnswer");

        }

    }
}
