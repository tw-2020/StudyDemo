using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Article
    {
        public int ArticleID { set; get; }
        public string Author { set; get; }
        public string Subject { set; get; }
        public string Content { set; get; }
        public int BlogID { set; get; }
        public DateTime Time { set; get;}
    }
}