using ExamApi.Models;
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
        public int PaperID { get; set; }
        public int StuID { get; set; }
        public int TeacherID { get; set; }
        public int AnswerScore { get; set; }
        public DateTime? AnswerTime { get; set; }
        public DateTime? SubmitTime { get; set; }
        public DateTime? BatchTime { get; set; }
        public int AnswerState { get; set; }



        public virtual Paper Paper { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Detail> Detail { get; set; }
    }
}
