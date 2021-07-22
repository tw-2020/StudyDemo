using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourAPI.Models
{
    public class Orders
    {
        public int OrdersId { set; get; }

        public int CustomerId { set; get; }

        public DateTime OrdersDate { set; get; }

        public decimal Amount { set; get; }

        public int ManTimes { set; get; }

        public decimal Discount { set; get; }

        public decimal EffectiveAmount { set; get; }
    }
}
