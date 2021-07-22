using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourAPI.Models
{
    public class OrdersLineDetail
    {
        public int Id { set; get; }

        public int OrdersId { set; get; }

        public int LineId { set; get; }

        public DateTime TravelDate { set; get; }
    }
}
