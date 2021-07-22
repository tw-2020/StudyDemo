using ExamUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApi.Models
{
    public class Teacher
    {
        public Teacher()
        {
            this.Answer = new HashSet<Answer>();
        }
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherLoginName { get; set; }
        public string TeacherLoginPwd { get; set; }
        public string TeacherPhone { get; set; }
        public string TeacherEmail { get; set; }

        public virtual ICollection<Answer> Answer { set; get; }
    }
}
