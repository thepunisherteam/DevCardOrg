using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجاری است لطفا نام خودرا وارد کنید")]
        [MinLength(3,ErrorMessage = "این فیلد نمیتواند کم تر از 3 کاراکتر باشد")]
        [MaxLength(20,ErrorMessage = "بالای 20 کاراکتر نمیتواند باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجاری است لطفا ایمیل خودرا وارد کنید")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل خودرا وارد کنید")]
        [MinLength(15,ErrorMessage = "کم تر از 15 کاراکتر نمیباشد")]
        [MaxLength(50,ErrorMessage = "بالای 50 کاراکتر نمیتواند باشد")]
        public string Email { get; set; }

        public string Services { get; set; }

        [Required(ErrorMessage = "این فیلد اجاری است لطفا پیام خودرا وارد کنید")]
        [MinLength(10, ErrorMessage = "این فیلد نمیتواند کم تر از 2 کاراکتر باشد")]
        [MaxLength(20, ErrorMessage = "بالای 20 کاراکتر نمیتواند باشد")]
        public string message { get; set; }
    }
}
