using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourAPI.Models
{
    public class Line
    {
        public int LineId { set; get; }

        public int? LineTypeId { set; get; }
        public string LineName { set; get; }
        public int Days { set; get; }
        public decimal Price { set;get; }
        public string Vehicle { set; get; }
        public string Hotel { set; get; }
        public string HasMeal { set; get; }
    }
}
