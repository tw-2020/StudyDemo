using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourAPI.Models
{
    public partial class UserInfo
    {
        public int UserId { set; get; }
        public string UserAccount { set; get; }
        public string UserName { set; get; }
        public string UserPassword { set; get; }
        public string UserPosition { set; get; }
        public string UserGender { set; get; }

    }
}
