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
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            TempData.Keep("LoginId");
            TempData.Keep("LoginName");
            TempData.Keep("LoginPosition");
            string result1 = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Orders/GetAllOrders");
            List<Orders> orders = JsonConvert.DeserializeObject<List<Orders>>(result1);

            foreach (Orders orders1 in orders)
            {
                //将订单对应的客户查找出来
                var CustomerId = orders1.CustomerId;
                string customerResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Customer/GetCustomerById/" + CustomerId);
                orders1.Customer = JsonConvert.DeserializeObject<Customer>(customerResult);

                //将订单对应的OrderLineDetail中的Line集合查出来
                var OrdersId = orders1.OrdersId;
                string orderLineDetailResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/OrdersLineDetail/GetOrderLineDetailById/" + OrdersId);
                List<OrdersLineDetail> ordersLineDetails = JsonConvert.DeserializeObject<List<OrdersLineDetail>>(orderLineDetailResult);
                //循环查找出来的OrderLineDetail集合，查找出里面对应的Line
                List<Line> lines = new List<Line>();
                foreach (OrdersLineDetail OrdersLineDetail in ordersLineDetails)
                {
                    var LineId = OrdersLineDetail.LineId;
                    //查找出对应的Line
                    string lineResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/Line/GetLineById/" + LineId);
                    Line line = JsonConvert.DeserializeObject<Line>(lineResult);

                    //查找出对应的lineType
                    string lineTypeResult = HttpHelper.HttpGetAsync(ConfigObject.BaseURL + "api/LineType/GetLineTypeById/" + line.LineTypeId);
                    line.LineType = JsonConvert.DeserializeObject<LineType>(lineTypeResult);
                    lines.Add(line);
                }
                //查出之后将所有line放到orders里
                orders1.Line = lines;
            }

            return View(orders);
        }

        public IActionResult Create()
        {

            return View();
        }
    }
}
