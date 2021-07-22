using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourUI.Common;
using TourUI.Models;

namespace TourUI.Controllers
{
    public class LineTypeController : Controller
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
            string result1 = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/LineType/GetAllLine");
            List<LineType> customers = JsonConvert.DeserializeObject<List<LineType>>(result1);
            return View(customers);
        }

        public IActionResult Create()
        {
            return PartialView();
        }
        /// <summary>
        /// 创建新路线
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(LineType lineType)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/LineType/CreateLineType", lineType);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 查找出线路
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/LineType/GetLineTypeById/" + id);
            LineType lineType = JsonConvert.DeserializeObject<LineType>(result);
            return PartialView(lineType);
        }

        /// <summary>
        /// 修改线路
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(LineType lineType)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/LineType/EditLineType", lineType);
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
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/LineType/GetLineTypeById/" + id);
            LineType lineType = JsonConvert.DeserializeObject<LineType>(result);
            return PartialView(lineType);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Delete(int id)
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/LineType/GetLineTypeById/" + id);
            LineType lineType = JsonConvert.DeserializeObject<LineType>(result);
            return PartialView(lineType);
        }
        [HttpPost]
        public IActionResult DeleteConfig(int LineTypeId)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/LineType/DeleteLineTypeById/" + LineTypeId,null);
            return RedirectToAction("index");
        }

    }
}
