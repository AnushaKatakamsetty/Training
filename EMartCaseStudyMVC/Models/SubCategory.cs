using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMartCaseStudyMVC.Models
{
    public class SubCategory
    {
        [Key]
        public int Sid { get; set; }
        public string Scname { get; set; }
        public string Details { get; set; }
    }
}
