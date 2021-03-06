﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnValidation.Models
{
    public class Employer
    {
        [Required(ErrorMessage = "Pls Enter ID")]
        [DisplayName("Employee ID")]
        [RegularExpression("[0-9]{1,5}",ErrorMessage="Invalid emp id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Pls Enter Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name length should be b/w 4 to 20 chars")]
        [DisplayName("Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pls Enter EmailID")]
        [DisplayName("Employee MailId")]
        [EmailAddress(ErrorMessage = "Invalid Email ID")]
        public string MailID { get; set; }
        [Required(ErrorMessage = "Pls Enter Mobile NO")]
        [DisplayName("Employee Mobile NO")]
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Invalid Mobile NO")]
        public string mobileNO { get; set; }
        [Required(ErrorMessage = "Pls Enter User Name")]
        [DisplayName("UserNAme")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Pls Enter Password")]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password Mismatch")]
        [DisplayName("Confirm Your Password")]
        public string CmpPassword { get; set; }

    }
}
