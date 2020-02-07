using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMartCaseStudyMVC.Models
{
    public class Category
    {
        [Key]
        public int cid { get; set; }
        public string cname { get; set; }
        public string breifdetails { get; set; }
    }
}
