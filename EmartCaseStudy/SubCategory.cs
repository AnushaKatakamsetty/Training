using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartCaseStudy
{
    class SubCategory:Category
    {
       
       public  int subcategory_id { get; set; }
        public string subcategory_name { get; set; }
        public string subcategory_details { get; set; }
        public SubCategory()
        { }
       public SubCategory(int category_id, string category_name, int subcategory_id, string subcategory_name, string subcategory_details):base(category_id,category_name)
        {
           // this.category_id = category_id;
        }
        List<SubCategory> subcatlist = new List<SubCategory>();
        List<Item> items = new List<Item>();
       
    }
}
