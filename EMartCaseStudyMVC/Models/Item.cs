using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMartCaseStudyMVC.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }
        public double price { get; set; }
        public string item_name { get; set; }
        public int category_id { get; set; }
        public int scatogery_id { get; set; }
        public string description { get; set; }
        public int stockNO { get; set; }
        public string remarks { get; set; }
        public double Gst { get; set; }
    }
}
