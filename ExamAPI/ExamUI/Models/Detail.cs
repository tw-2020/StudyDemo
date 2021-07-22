
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamUI.Models
{
     
    public class Detail
    {
        public Detail()
        {

        }
        public int DetailId { get; set; }
        [Display(Name = "考试Id")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int AnswerId { get; set; }
        [Display(Name = "试题Id")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int TopicId { get; set; }
        [Display(Name = "考试详情")]
        public string DetailAnswer { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual Answer Answer { get; set; }
    }
}
