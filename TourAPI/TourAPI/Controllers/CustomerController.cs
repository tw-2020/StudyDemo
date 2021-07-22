using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourAPI.Models;

namespace TourAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : Controller
    {
        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public int  CreateCustomer(Customer customer)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                db.Customer.Add(customer);
                i = db.SaveChanges();
            }
            return i;
        }

        /// <summary>
        /// 通过id取得Customer的详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Customer GetCustomerById(int id)
        {
            Customer customer = null;
            using (TourContext db = new TourContext())
            {
                customer = db.Customer.FirstOrDefault(t => t.CustomerId == id);
            }
            return customer;
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public int UpdateCustomer(Customer customer)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                db.Entry(customer).State = EntityState.Modified;
                i = db.SaveChanges();
            }
            return i;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public int DeleteCustomer(int id)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                Customer student = db.Customer.Find(id);
                db.Customer.Remove(student);
                db.SaveChanges();
            }
            return i;
        }
    }
}
