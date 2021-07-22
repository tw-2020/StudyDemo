using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourAPI.Models
{
    public partial class Customer
    {
        public int CustomerId { set; get; }
        public string CustomerName { set; get; }
        public string Gender { set; get; }
        public string IdentityId { set; get; }
        public string TEL { set; get; }
    }
}
