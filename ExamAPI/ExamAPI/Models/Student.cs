using ExamUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApi.Models
{
    public class Student
    {
        public Student()
        {
            this.Answer = new HashSet<Answer>();
        }
        public int StuID { get; set; }
        public string StuName { get; set; }       
        public string StuLoginName { get; set; }  
        public string StuLoginPwd { get; set; }   
        public bool StuSex { get; set; }
        public string StuPhone { get; set; }
        public string StuEmail { get; set; }
        public string StuGrade { get; set; }

        public virtual ICollection<Answer> Answer { set; get; }
    }
}
