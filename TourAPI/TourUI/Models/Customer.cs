using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourUI.Models
{
    public partial class Customer
    {
        public int CustomerId { set; get; }
        [Display(Name = "客户姓名")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string CustomerName { set; get; }
        [Display(Name = "客户性别")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string Gender { set; get; }
        [Display(Name = "客户身份证号")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string IdentityId { set; get; }
        [Display(Name = "客户电话")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string TEL { set; get; }
    }
}
