using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartCaseStudy
{
    class SellerBO:ItemBO
    {
        public int sid { get; set; }
        public string suser_name { get; set; }
        public string password { get; set; }
        public string company_name { get; set; }
        public  string GST { get; set; }
        public string Poastal_address { get; set; }
        public string Website { get; set; }
        public string email_id { get; set; }
        public double contact_no { get; set; }
        public SellerBO()
        { }
        public SellerBO(int sid, string suser_name, string password, string company_name, string GST, string Poastal_address, string Website, string email_id, double contact_no)
        {
            this.sid = sid;
            this.suser_name = suser_name;
            this.password = password;
            this.company_name = company_name;
            this.GST = GST;
            this.Poastal_address = Poastal_address;
            this.Website = Website;
            this.email_id = email_id;
            this.contact_no = contact_no;
        }
        public bool CheckSeller()
        {
            Console.WriteLine("enter username");
            suser_name = Console.ReadLine();
            Console.WriteLine("enter password");
            password = Console.ReadLine();
            if (suser_name == "seller" && password == "seller")
            {
                Console.WriteLine("login successfull");
                return true;
            }
            else if (suser_name == "seller" || password == "seller")
            {
                Console.WriteLine("incorrect username or password");
                return false;
            }
            else
            {
                Console.WriteLine("invalid user");
                return false;
            }
        }
        //Category cat;
        //cat= new SubCategory();
        //List<Category> cat = new List<Category>();
        
    }
}
