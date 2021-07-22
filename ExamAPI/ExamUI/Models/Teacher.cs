using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamUI.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            this.Answer = new HashSet<Answer>();
        }

        public int TeacherID { get; set; }
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string TeacherName { get; set; }
        [Display(Name = "登录名")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string TeacherLoginName { get; set; }
        [Display(Name = "密码")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string TeacherLoginPwd { get; set; }
        [Display(Name = "电话")]
        public string TeacherPhone { get; set; }
        [Display(Name = "Email")]
        public string TeacherEmail { get; set; }

        public virtual ICollection<Answer> Answer { get; set; }
    }
}
