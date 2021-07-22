using ExamAPI.Models;
using ExamUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApi.Models
{
    public class Paper
    {
        public Paper()
        {
            this.Answer = new HashSet<Answer>();
            this.Topic = new HashSet<Topic>();
        }

        public int PaperID { set; get; }
        public string PaperName { set; get; }
        public string PaperExplain { set; get; }
        public int PaperTime { set; get; }

        public virtual ICollection<Answer> Answer { set; get; }
        public virtual ICollection<Topic> Topic { get; set; }

    }
}
