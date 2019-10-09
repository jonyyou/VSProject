using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EduMS.MVCSite.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "请输入用户名")]
        [Display(Name = "用户名")]
        public string loginName { get; set; }

        [Required(ErrorMessage = "请输入密码")]
        [Display(Name = "密码")]
        public string pwd { get; set; }

        public string identity { get; set; }
    }
}