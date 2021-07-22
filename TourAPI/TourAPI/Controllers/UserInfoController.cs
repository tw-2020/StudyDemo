using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourAPI.Models;
using TourAPI.ViewModels;

namespace TourAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserInfoController : Controller
    {
        /// <summary>
        ///  用户登录
        /// </summary>
        /// <returns> 用户实体 </returns>
        [HttpPost]
        public UserInfo Login(UserInfoLoginViewModel UserInfoLoginViewModel)
        {
            UserInfo UserInfo = null;
            using (TourContext db = new TourContext())
            {
                UserInfo = db.UserInfo.FirstOrDefault(t =>
                t.UserAccount == UserInfoLoginViewModel.UserAccount &&
                t.UserPassword == UserInfoLoginViewModel.UserPassword);
            }
            return UserInfo;
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public int CreateUserInfo(UserInfo userInfo)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                db.UserInfo.Add(userInfo);
                i = db.SaveChanges();
            }
            return i;
        }


        /// <summary>
        /// 获取User详情信息
        /// </summary>
        /// <returns></returns>
        [HttpPost("{userAaccount}")]
        public UserInfo GetUserInfo(string userAaccount)
        {
            UserInfo userInfo = null;
            using (TourContext db = new TourContext())
            {
                userInfo = db.UserInfo.FirstOrDefault(t => t.UserAccount == userAaccount);
            }

            return userInfo;
        }

        /// <summary>
        /// 修改UserInfo信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public int UpdateUser(UserInfo userInfo)
        {
            int num = 0;
            using (TourContext db = new TourContext())
            {
                db.Entry(userInfo).State = EntityState.Modified;
                num = db.SaveChanges();
            }
            return num;
        }

        /// <summary>
        /// 获取所有的客户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Customer> GetAllCustomers()
        {
            List<Customer> customers = null;
            using (TourContext db = new TourContext())
            {
                customers = db.Customer.ToList();
            }
            return customers;
        }
    }
}
