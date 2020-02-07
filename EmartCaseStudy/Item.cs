using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartCaseStudy
{
    class Item
    {
        public int item_id { get; set; }
        public double price { get; set; }
        public string item_name { get; set; }
        public string description { get; set; }
        public int stock_number { get; set; }
        public string remarks { get; set; }
       // public int no_of_items { get; set; }
        public int sellerid { get; set; }
        public SubCategory scategory { get; set; }

        public Item(int category_id, int subcategory_id,int item_id, string item_name,double price, string description, int stock_number, string remarks)
        {
            this.item_id = item_id;
            this.item_name = item_name;
            this.price = price;
            //this.no_of_items = no_of_items;
            this.description = description;
            this.stock_number = stock_number;
            this.remarks = remarks;
        }
        //int category_id;
        //int subcategory_id;

        //public Item(int item_id,string item_name,SubCategory sc)
        //{
        //    this.item_id = item_id;
        //    this.item_name = item_name;
        //}
    }
}
