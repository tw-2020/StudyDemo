using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourUI.Models
{
    public class Line
    {
        public int LineId { set; get; }
        [Display(Name = "旅游线路Id")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int? LineTypeId { set; get; }
        [Display(Name = "景点名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string LineName { set; get; }
        [Display(Name = "旅行时间（天）")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int Days { set; get; }
        [Display(Name = "景点价格")]
        [Required(ErrorMessage = "{0}是必填项")]
        public decimal Price { set; get; }
        [Display(Name = "交通工具")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string Vehicle { set; get; }
        [Display(Name = "酒店星级")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string Hotel { set; get; }
        [Display(Name = "有无早餐")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string HasMeal { set; get; }

        public virtual LineType LineType { set; get; }
    }
}
