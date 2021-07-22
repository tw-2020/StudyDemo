using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourUI.Common;
using TourUI.Models;

namespace TourUI.Controllers
{
    public class LineController : Controller
    {
        /// <summary>
        /// 显示线路列表名
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            TempData.Keep("LoginId");
            TempData.Keep("LoginName");
            TempData.Keep("LoginPosition");
            string result1 = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Line/GetAllLine");
            List<Line> customers = JsonConvert.DeserializeObject<List<Line>>(result1);
            return View(customers);
        }

        public IActionResult Create()
        {
            List<SelectListItem> li = new List<SelectListItem>();

            li.Add(new SelectListItem() { Text = "国内断线游", Value = "1" });
            li.Add(new SelectListItem() { Text = "国内长线游", Value = "2" });
            li.Add(new SelectListItem() { Text = "出境游", Value = "3" });

            ViewBag.Type = li;

            return PartialView();
        }
        /// <summary>
        /// 创建新路线
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Line Line)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Line/CreateLine", Line);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 查找出景区
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Line/GetLineById/" + id);
            Line Line = JsonConvert.DeserializeObject<Line>(result);

            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem() { Text = "国内断线游", Value = "1" });
            li.Add(new SelectListItem() { Text = "国内长线游", Value = "2" });
            li.Add(new SelectListItem() { Text = "出境游", Value = "3" });
            ViewBag.Type = li;

            return PartialView(Line);
        }

        /// <summary>
        /// 修改线路
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(Line Line)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Line/EditLine", Line);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 查询信息，跳转页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Detail(int id)
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Line/GetLineById/" + id);
            Line Line = JsonConvert.DeserializeObject<Line>(result);

            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem() { Text = "国内断线游", Value = "1" });
            li.Add(new SelectListItem() { Text = "国内长线游", Value = "2" });
            li.Add(new SelectListItem() { Text = "出境游", Value = "3" });
            ViewBag.Type = li;

            return PartialView(Line);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Delete(int id)
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Line/GetLineById/" + id);
            Line Line = JsonConvert.DeserializeObject<Line>(result);

            List<SelectListItem> li = new List<SelectListItem>();

            li.Add(new SelectListItem() { Text = "国内断线游", Value = "1" });
            li.Add(new SelectListItem() { Text = "国内长线游", Value = "2" });
            li.Add(new SelectListItem() { Text = "出境游", Value = "3" });

            ViewBag.Type = li;

            return PartialView(Line);
        }
        [HttpPost]
        public IActionResult DeleteConfig(int LineId)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Line/DeleteLineById/" + LineId, null);
            return RedirectToAction("index");
        }
    }
}
