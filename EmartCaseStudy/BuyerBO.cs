using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartCaseStudy
{
    class BuyerBO:ItemBO
    {
        public int bid { get; set; }
        public string buser_name { get; set; }
        public string password { get; set; }
        public string email_id { get; set; }
        public double mobile_no { get; set; }
        public string address { get; set; }
        public DateTime CreatedDate { get; set; }
        //string choice = null;
        public BuyerBO()
        {
        }
        public  BuyerBO(int bid, string buser_name,string  password,double mobile_no,string  email_id,string  address,DateTime CreatedDate)
        {
            this.bid = bid;
            this.buser_name = buser_name;
            this.password = password;
            this.mobile_no = mobile_no;
            this.email_id = email_id;
            this.address = address;
            this.CreatedDate = CreatedDate;
            Buyer b = new Buyer(this.bid, this.buser_name,this.password, this.mobile_no, this.email_id,this.CreatedDate);
        }
        public void CheckBuyer()
        {
            Console.WriteLine("enter username");
            buser_name = Console.ReadLine();
            Console.WriteLine("enter password");
            password = Console.ReadLine();
            if (buser_name == "buyer" && password == "buyer")
            {
                Console.WriteLine("login successfull");
                
            }
            else if (buser_name == "buyer" || password == "buyer")
                Console.WriteLine("incorrect username or password");
            else
                Console.WriteLine("Invalid user");
        }
        //public override void displayCategoryList()
        //{
        //    Console.WriteLine("----------------Product Category--------------------");
        //    Console.WriteLine("\n 1.Electronic goods \n 2.Tvs & Appliances \n 3.Home & furniture \n 4.Mens \n 5.Womens \n 6.Sports Books & more \n 7.offer Zone");

        //    Console.WriteLine("Enter Category :");
        //    int opt1 = int.Parse(Console.ReadLine());
        //    switch (opt1)
        //    {


        //    }
        //}
        static List<Buyer> blist = new List<Buyer>();
        DateTime t = new DateTime();
        // static List<Buyer> bl = new List<Buyer>();
      
        public void signup(int id, string uname, string password, string email, double mobile_no)
        {
            blist.Add(new Buyer(id, uname,password, mobile_no,email,CreatedDate));
            Console.WriteLine("Registration Done...");
        }
        public void viewDetails()
        {
            foreach (Buyer e1 in blist)
            {
                Console.WriteLine(e1.ToString() + " " + t.Date);
            }
        }
        public void Search()
        {
            ibo.Search();
        }
        public void DisplayCategory()
        {
            ibo.DisplayProducts();

        }
        public void DisplayDetails()
        {
            Console.WriteLine("Details...............");
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Phone Number : " + phno);
            Console.WriteLine("Email : " + email);
        }
    }
}
