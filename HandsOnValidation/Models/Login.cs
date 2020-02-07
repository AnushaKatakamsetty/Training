using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnValidation.Models
{
    public class Login
    {
        [Required(ErrorMessage="username is required")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "password is required")]
        public string Password { get; set; }
    }
}
