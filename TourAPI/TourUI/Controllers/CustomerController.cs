using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourUI.Models;
using TourUI;
using TourUI.Common;
using Newtonsoft.Json;

namespace TourUI.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            TempData.Keep("LoginId");
            TempData.Keep("LoginName");
            TempData.Keep("LoginPosition");
            string result1 = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/UserInfo/GetAllCustomers");
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(result1);
            ViewBag.Customers = customers;

            return View();
        }
        public IActionResult Create()
        {
            return PartialView();
        }
        /// <summary>
        /// 创建新客户
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Customer/CreateCustomer", customer);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int id) //先查找
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Customer/GetCustomerById/" + id);
            Customer customer = JsonConvert.DeserializeObject<Customer>(result);
            return PartialView(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Customer/UpdateCustomer", customer);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 用户详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Detail(int id) 
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Customer/GetCustomerById/" + id);
            Customer customer = JsonConvert.DeserializeObject<Customer>(result);
            return PartialView(customer);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Delete(int id) //先查找
        {
            string result = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Customer/GetCustomerById/" + id);
            Customer customer = JsonConvert.DeserializeObject<Customer>(result);
            return PartialView(customer);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int CustomerId)
        {
            string result = HttpHelper.HttpPostAsync(ConfigObject.BaseURL + "api/Customer/DeleteCustomer/"+ CustomerId,null);
            return RedirectToAction("Index");
        }

    }
}
