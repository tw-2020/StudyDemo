using TourUI;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourUI.Common;
using TourUI.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TourUI.Controllers
{
    public class HomeController : Controller
    {
        //首页面
        public IActionResult Index()
        {
            TempData.Keep("LoginId");
            TempData.Keep("LoginName");
            TempData.Keep("LoginPosition");
            if (TempData["loginId"] != null)
            {
                return View();
            }
            return RedirectToAction("Login");
        }

        //登录页面
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string UserAccount, string UserPassword)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/UserInfo/Login",
                new
                {
                    UserAccount = UserAccount,
                    UserPassword = UserPassword
                });
            UserInfo UserInfo = JsonConvert.DeserializeObject<UserInfo>(result);

            if (UserInfo != null)
            {
                TempData["LoginId"] = UserInfo.UserId;
                TempData["LoginName"] = UserInfo.UserName;
                TempData["LoginPosition"] = UserInfo.UserPosition;
                return RedirectToAction("Index"); 
            }
            ModelState.AddModelError("", "学生帐号或密码错误!");
            return View();
        }

        //注册页面
        public IActionResult Register()
        {
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem() { Text = "男", Value = "男" });
            li.Add(new SelectListItem() { Text = "女", Value = "女" });
            ViewBag.Gender = li;
            return View();  
        }
        [HttpPost]
        public IActionResult Register(UserInfo userInfo)
        {
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem() { Text = "男", Value = "男" });
            li.Add(new SelectListItem() { Text = "女", Value = "女" });
            ViewBag.Gender = li;
            if (ModelState.IsValid)
            {
                HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/UserInfo/CreateUserInfo", userInfo);
                return RedirectToAction("Index");
            }
            return View();
        }

        /// <summary>
        /// 忘记密码页面
        /// </summary>
        /// <returns></returns>
        public IActionResult ForgetPwd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForgetPwd(string userAccount, string userPassword)
        {

            //先查找出来账户
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/UserInfo/GetUserInfo/"+userAccount,null);
            UserInfo userInfo = JsonConvert.DeserializeObject<UserInfo>(result);

            userInfo.UserPassword = userPassword;
            string upResult = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/UserInfo/UpdateUser", userInfo);
            return RedirectToAction("Index");
        }

       

        //退出登录
        public IActionResult Logout()
        {
            TempData["LoginId"] = null;
            TempData["LoginName"] = null;
            TempData["LoginPosition"] = null;
            return RedirectToAction(nameof(Login));
        }

    }
}
