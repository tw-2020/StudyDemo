using ExamAPI.Models;
using ExamUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApi.Models
{
    public class Detail 
    {
        public Detail()
        { 
        
        }

        public int DetailID { set; get; }
        public int AnswerID { set; get; }
        public int TopicID { set; get; }
        public string DetailAnswer { set; get; }

        public virtual Topic Topic { get; set; }
        public virtual Answer Answer { get; set; }
    }
}
