using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourUI.Models
{
    public class OrdersLineDetail
    {
        public int Id { set; get; }

        public int OrderId { set; get; }

        public int LineId { set; get; }
        [Display(Name = "出行日期")]
        [Required(ErrorMessage = "{0}是必填项")]
        public DateTime TravelDate { set; get; }


        public virtual Line Line { set; get; }
    }
}
