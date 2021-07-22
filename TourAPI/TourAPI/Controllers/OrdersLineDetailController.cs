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
    public class OrdersLineDetailController : Controller
    {
        /// <summary>
        /// 获取所有订单路线详情
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<OrdersLineDetail> GetAllOrderLineDetail()
        {
            List<OrdersLineDetail> OrderLineDetails = null;
            using (TourContext db = new TourContext())
            {
                OrderLineDetails = db.OrdersLineDetail.ToList();
            }
            return OrderLineDetails;
        }
        /// <summary>
        /// 添加新的订单路线详情
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public int CreateOrderLineDetail(OrdersLineDetail OrderLineDetail)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                db.OrdersLineDetail.Add(OrderLineDetail);
                i = db.SaveChanges();
            }
            return i;
        }
        /// <summary>
        /// 根据OrdreId查找订单路线详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public List<OrdersLineDetail> GetOrderLineDetailById(int id)
        {
            List<OrdersLineDetail> OrderLineDetail = null;
            using (TourContext db = new TourContext())
            {
                OrderLineDetail = db.OrdersLineDetail.Where(a =>a.OrdersId == id).ToList();
            }
            return OrderLineDetail;
        }
        /// <summary>
        /// 编辑订单路线详情
        /// </summary>
        /// <param name="OrderLineDetail"></param>
        /// <returns></returns>
        [HttpPost]
        public int EditOrderLineDetail(OrdersLineDetail OrderLineDetail)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                db.Entry(OrderLineDetail).State = EntityState.Modified;
                i = db.SaveChanges();
            }
            return i;
        }
        /// <summary>
        /// 根据id删除订单路线详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public int DeleteOrderLineDetailById(int id)
        {
            int i = 0;
            using (TourContext db = new TourContext())
            {
                OrdersLineDetail student = db.OrdersLineDetail.Find(id);
                db.OrdersLineDetail.Remove(student);
                db.SaveChanges();
            }
            return i;
        }
    }
}
