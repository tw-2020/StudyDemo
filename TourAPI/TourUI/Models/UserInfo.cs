using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourUI.Models
{
    public partial class UserInfo
    {
        public int UserId { set; get; }

        [Display(Name = "用户账号")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string UserAccount { set; get; }

        [Display(Name = "用户姓名")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string UserName { set; get; }

        [Display(Name = "用户密码")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string UserPassword { set; get; }

        [Display(Name = "用户职位")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string UserPosition { set; get; }

        [Display(Name = "性别")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string UserGender { set; get; }
    }
}
