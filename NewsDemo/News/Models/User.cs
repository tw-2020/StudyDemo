using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace News.Models
{
    [Table("tb_User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public DateTime addDate { get; set; }
    }
}