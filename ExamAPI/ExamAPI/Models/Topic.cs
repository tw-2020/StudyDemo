using ExamApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamAPI.Models
{
    public class Topic
    {
        public Topic()
        {
            this.Detail = new HashSet<Detail>();
        }

        public int TopicId { get; set; }    
        public string TopicExplain { get; set; }
        public int TopicScore { get; set; }
        public int TopicType { get; set; }
        public string TopicA { get; set; }
        public string TopicB { get; set; }
        public string TopicC { get; set; }
        public string TopicD { get; set; }
        public int TopicSort { get; set; }
        public string TopicAnswer { get; set; }
        public int PaperId { get; set; }

        public virtual Paper Paper { get; set; }

        public virtual ICollection<Detail> Detail { get; set; }


    }
}
