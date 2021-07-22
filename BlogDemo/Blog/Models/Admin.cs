using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Admin
    {
        public int ID { set; get; }
        public string UserName { set; get; }
        public string PassWord { set; get; }
        public string ReallyName { set; get; }
        public string Birthday { set; get; }
        public string Address { set; get; }
        public string PostCode { set; get; }
        public string Email { set; get; }
        public string HomePhone { set; get; }
        public string MobilePhone { set; get; }
        public string QQ { set; get; }
        public string ICQ { set; get; }
        public DateTime RegTime { set; get; }
        public string Sex { set; get; }
        public string IP { set; get; }
        public int BlogID { set; get; }
        public string SuperAdmin { set; get; }

    }
}