using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validate.Models
{
    public class UserInfo
    {
        [Required]
        [StringLength(maximumLength:10,ErrorMessage ="用户名长度应该在4-10个字符之间!",MinimumLength=4)]
        [Display(Name ="用户名")]
        public string UserName { get; set; }

        [Required]
        [StringLength(10,ErrorMessage ="密码不少于6个字符",MinimumLength =6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "两次输入的密码不一致")]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")]
        public string Email { get; set; }

        [Required]
        [Range(1,maximum:100,ErrorMessage ="输入年龄在1-100之间")]
        public string Age { get; set; }
    }
}