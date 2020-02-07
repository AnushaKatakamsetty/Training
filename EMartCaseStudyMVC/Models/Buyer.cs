using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMartCaseStudyMVC.Models
{
    public class Buyer
    {
        [Key]
        [Required(ErrorMessage ="Please fill the field")]
        public int bId { get; set; }
        [Required(ErrorMessage = "Please fill the field")]
        public string bUname { get; set; }
        //[DataType]
        [Required(ErrorMessage = "Please fill the field")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please fill the field")]
        public string Mailid { get; set; }
        [Required(ErrorMessage = "Please fill the field")]
        public long Mobileno { get; set; }
       
    }
}


