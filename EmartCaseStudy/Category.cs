using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartCaseStudy
{
   abstract class Category
    {
        public string category_name {get; set;}
        public int category_id { get; set; }
        public Category()
        { }
        public Category(int category_id,string category_name)
        {
            this.category_id =category_id;
            this.category_name = category_name;
        }
        // abstract public void displayCategoryList();
        //public string CategoryList(int category_id, string category_name,out int cid)
        //{
        //    Console.WriteLine("enter category id");
        //    category_id = int.Parse(Console.ReadLine());
        //    cid = category_id;
        //    Console.WriteLine("enter category name");
        //    category_name = Console.ReadLine();
        //    return  category_name;
        //}
       

    }
}
