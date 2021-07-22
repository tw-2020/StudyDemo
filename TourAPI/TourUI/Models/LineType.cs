using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourUI.Models
{
    public partial class LineType
    {
        public int LineTypeId { set; get; }
        [Display(Name = "旅游线路")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string TypeName { set; get; }
    }
}
