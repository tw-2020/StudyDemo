using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourUI.Models
{
    public partial class Orders
    {
        public Orders()
        {
            this.OrdersLineDetail = new HashSet<OrdersLineDetail>();
            this.Line = new HashSet<Line>();
        }
        public int OrdersId { set; get; }

        public int CustomerId { set; get; }
        [Display(Name = "订单日期")]
        [Required(ErrorMessage = "{0}是必填项")]
        public DateTime OrdersDate { set; get; }
        [Display(Name = "订单金额")]
        [Required(ErrorMessage = "{0}是必填项")]
        public decimal Amount { set; get; }
        [Display(Name = "订购人次")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int ManTimes { set; get; }
        [Display(Name = "折扣系数")]
        [Required(ErrorMessage = "{0}是必填项")]
        public decimal Discount { set; get; }
        [Display(Name = "实际金额")]
        [Required(ErrorMessage = "{0}是必填项")]
        public decimal EffectiveAmount { set; get; }

        public virtual Customer Customer { set; get; }
        public virtual ICollection<OrdersLineDetail> OrdersLineDetail { set; get; }
        public virtual ICollection<Line> Line { set; get; }
    }
}
