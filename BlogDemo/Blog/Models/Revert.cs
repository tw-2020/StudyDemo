using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Revert
    {
        public int RevertID { set; get; }
        public string Subject { set; get; }
        public string Content { set; get; }
        public int ArticleID { set; get; }
        public int BlogID { set; get; }
        public DateTime Time { set; get; }
        public string IP { set; get; }
        public int VisitorID { set; get; }
        public string VisitorName { set; get; }
    }
}