using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Mvc.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Lütfen Email adresinizi giriniz")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi  giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Lütfen şifrenizi tekrar  giriniz")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }

    }
}
