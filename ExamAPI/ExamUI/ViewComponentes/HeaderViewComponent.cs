using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ExamUI.ViewComponentes
{
    public class HeaderViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            ViewBag.LoginID = Convert.ToInt32(TempData.Peek("LoginID"));
            ViewBag.LoginName = Convert.ToString(TempData.Peek("LoginName"));
            ViewBag.Type = Convert.ToString(TempData.Peek("Type"));
            return View();
        }
    }
}
