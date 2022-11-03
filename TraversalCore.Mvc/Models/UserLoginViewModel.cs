using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Mvc.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Lütfen şifrenizi  giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
