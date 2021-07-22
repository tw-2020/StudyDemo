using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamUI.Models
{
    public partial class Answer
    {
        public Answer()
        {
            this.Detail = new HashSet<Detail>();
        }

        public int AnswerID { get; set; }
        [Display(Name = "试题ID")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int PaperID { get; set; }
        [Display(Name = "学生ID")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int StuID { get; set; }
        [Display(Name = "阅卷老师ID")]
        public int TeacherID { get; set; }
        [Display(Name = "分数")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int AnswerScore { get; set; }
        [Display(Name = "答题时间")]
        public DateTime? AnswerTime { get; set; }
        [Display(Name = "提交时间")]
        public DateTime? SubmitTime { get; set; }
        [Display(Name = "阅卷时间")]
        public DateTime? BatchTime { get; set; }
        [Display(Name = "试卷状态")]
        public int AnswerState { get; set; }



        public virtual Paper Paper { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Detail> Detail { get; set; }
    }
}
