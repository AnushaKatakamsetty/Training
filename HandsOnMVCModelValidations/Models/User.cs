using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HandsOnMVCModelValidations.Models
{
    public class User
    { 
        [Required(ErrorMessage="Please enter the name")]
        [DisplayName("Name")]
        [StringLength(maximumLength: 20, MinimumLength =3, ErrorMessage = "Name length should be b/w 4 to 20 chars")]
        public string Name { get; set; }
        
        [Required(ErrorMessage="Please enter Email ID")]
        [DisplayName("Email ID")]
        [EmailAddress(ErrorMessage ="Please enter a valid email id")]
        public string Email { get; set; }

        [Required(ErrorMessage="Please select  dob")]
      //  [DisplayName("UserName")]
        public DateTime DOB { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage="Please select your country")]
       // [DisplayName("UserName")]
        public string Country { get; set; }

        [Required(ErrorMessage="Please enter the username")]
        [DisplayName("UserName")]
        
       [StringLength(maximumLength:20,MinimumLength =5,ErrorMessage ="entered username is too short or too long")]
        [RegularExpression("[a-zA-Z]", ErrorMessage = "please enter a valid username")]
        public string UserName { get; set; }

        [Required(ErrorMessage="Please enter the valid password")]
        [DisplayName("Password")]
        [StringLength(maximumLength: 15,MinimumLength=8,ErrorMessage ="paswd should contain min 8 chars")]
        [RegularExpression("[a-z]")]
        public string Password{ get; set; }

    }
}
