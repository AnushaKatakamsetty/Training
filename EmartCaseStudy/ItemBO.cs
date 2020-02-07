using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartCaseStudy
{
    class ItemBO
      //  List<SubCategory> subcatlist = new List<SubCategory>();
   // List<Item> items = new List<Item>();

    {
        static List<Item> Ilist = new List<Item>();
        static List<SubCategory> Slist = new List<SubCategory>();
        public void AddCatandSubcategory(int c_id, string cname, int s_id, string scname, string scdes)
        {
            Slist.Add(new SubCategory(c_id, cname, s_id, scname, scdes));
        }
        public void AddItems(int c_id, int s_id, int id, double pri,string item_nam, string des, int st, string rem, double gst)
        {
            //List<Subcategory> s1 = Slist.FindAll(e => e.cid == c_id);

            Ilist.Add(new Item(c_id, s_id, id,item_nam,pri, des, st, rem));
        }
		public void viewItems()
		{

			Console.WriteLine("Category List..");
			foreach (SubCategory i in Slist)
			{
				Console.WriteLine("Category Id.." + i.category_id + "\tCategory Name.." + i.category_name);
			}
			Console.WriteLine("Enter Category Id..Which you want to view..");
			int opt = int.Parse(Console.ReadLine());
			List<SubCategory> sl = Slist.FindAll(e => e.category_id == opt);
			foreach (SubCategory s in sl)
			{
				Console.WriteLine("Subcatogery id.." + s.subcategory_id+ "\tSubcatogery name.." + s.subcategory_name+ "\tAbout Subcatogery.." + s.subcategory_details);
			}
			Console.WriteLine("Enter Subcatogery id To View Products..");
			int opt2 = int.Parse(Console.ReadLine());
			List<Item> il = Ilist.FindAll(e1 => e1.subcategory_id == opt2);
			foreach (Item i in il)
			{
				Console.WriteLine(i.ToString());
			}

		}
	}
}
