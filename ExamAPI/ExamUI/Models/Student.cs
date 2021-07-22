using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamUI.Models
{
    public partial class Student
    {
        public Student()
        {
            this.Answer = new HashSet<Answer>();
        }
        public int StuID { get; set; }
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string StuName { get; set; }
        [Display(Name = "登录名")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string StuLoginName { get; set; }
        [Display(Name = "密码")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string StuLoginPwd { get; set; }
        [Display(Name = "性别")]
        [Required(ErrorMessage = "{0}是必填项")]
        public bool StuSex { get; set; }
        [Display(Name = "电话")]
        public string StuPhone { get; set; }
        [Display(Name = "Email")]
        public string StuEmail { get; set; }
        [Display(Name = "班级")]
        public string StuGrade { get; set; }

        public virtual ICollection<Answer> Answer { get; set; }
    }
}
