
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMartCaseStudyMVC.Models
{
    public class Seller
    {
        [Key]
        public int sid { get; set; }
        public string sname { get; set; }
        public string spassword { get; set; }
        public string scompanyname { get; set; }
        public string sgstin { get; set; }
        public string saboucompany { get; set; }
        public string saddress { get; set; }
        public string swebsite { set; get; }
        public string semailid { get; set; }
        public long smobileno { get; set; }
        public string PhotoPath { get; set; }
       
    }
}
