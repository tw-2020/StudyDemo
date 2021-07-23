using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace News.Models
{
    [Table("tb_News")]
    public class NewsModel
    {
        [Key]
        public int Id { set; get; }
        public string Title { set; get; }

        public string Content { set; get; }

        public string Style { set; get; }

        public string Type { set; get; }

        public DateTime IssueDate { set; get; }
    }
}