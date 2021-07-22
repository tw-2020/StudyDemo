
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamUI.Models
{
    public partial class Paper
    {
        public Paper()
        {
            this.Answer = new HashSet<Answer>();
            this.Topic = new HashSet<Topic>();
        }
        [Display(Name = "试卷id")]
        public int PaperID { set; get; }

        [Display(Name = "试卷名")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string PaperName { set; get; }

        [Display(Name = "试卷说明")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string PaperExplain { set; get; }

        [Display(Name = "试卷时长")]
        public int PaperTime { set; get; }
        public virtual ICollection<Answer> Answer { get; set; }
        public virtual ICollection<Topic> Topic { get; set; }
    }
}
