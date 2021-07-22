using ExamUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamUI.Models
{
    public partial class Topic
    {
        public Topic()
        {
            this.Detail = new HashSet<Detail>();
        }

        public int TopicId { get; set; }
        [Display(Name = "考题描述")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string TopicExplain { get; set; }
        [Display(Name = "该题分值")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int TopicScore { get; set; }
        [Display(Name = "类型")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int TopicType { get; set; }
        [Display(Name = "A选项")]
        public string TopicA { get; set; }
        [Display(Name = "B选项")]
        public string TopicB { get; set; }
        [Display(Name = "C选项")]
        public string TopicC { get; set; }
        [Display(Name = "D选项")]
        public string TopicD { get; set; }
        [Display(Name = "排序")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int TopicSort { get; set; }
        [Display(Name = "正确答案")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string TopicAnswer { get; set; }
        public int PaperId { get; set; }

        public virtual Paper Paper { get; set; }

        public virtual ICollection<Detail> Detail { get; set; }


    }
}
