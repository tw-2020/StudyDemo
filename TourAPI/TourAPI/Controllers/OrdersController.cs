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
    public class OrdersController : Controller
    {
        /// <summary>
        /// 获取所有订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Orders> GetAllOrders()
        {
            List<Orders> Orderss = null;
            using (TourContext db = new TourContext())
            {
                Orderss = db.Orders.ToList();
            }
            return Orderss;
        }
        /// <summary>
        /// 添加新的订单
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public int CreateOrders(Orders Orders)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                db.Orders.Add(Orders);
                i = db.SaveChanges();
            }
            return i;
        }
        /// <summary>
        /// 根据id查找订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Orders GetOrdersById(int id)
        {
            Orders Orders = null;
            using (TourContext db = new TourContext())
            {
                Orders = db.Orders.FirstOrDefault(t => t.OrdersId == id);
            }
            return Orders;
        }
        /// <summary>
        /// 编辑订单
        /// </summary>
        /// <param name="Orders"></param>
        /// <returns></returns>
        [HttpPost]
        public int EditOrders(Orders Orders)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                db.Entry(Orders).State = EntityState.Modified;
                i = db.SaveChanges();
            }
            return i;
        }
        /// <summary>
        /// 根据id删除订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public int DeleteOrdersById(int id)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                Orders student = db.Orders.Find(id);
                db.Orders.Remove(student);
                db.SaveChanges();
            }
            return i;
        }
    }
}
