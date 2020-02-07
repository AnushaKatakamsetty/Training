using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string buser_name, suser_name;
            string password;
            string email_id;
            double mobile_no, contact_no;
            string address;
            string company_name;
            string GST;
            string Website;
            string Postal_address;
            DateTime CreatedDate = Convert.ToDateTime(DateTime.Now);
            Admin a = new Admin();
            BuyerBO bbo = new BuyerBO();
            //int bid, string buser_name, string password, double mobile_no, string email_id, string address, DateTime CreatedDate
            Seller so = new Seller();
            SellerBO sbo;
            sbo = new SellerBO();
            Console.WriteLine("1.Admin\n2.Buyer\n3.Seller");
            int ch = 0, ch1 = 0;
            Console.WriteLine("enter the choice");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    a.CheckUser();
                    break;
                case 2:
                    Console.WriteLine("Buyer1.Sign Up\n2.Sign In");
                    Console.WriteLine("enter the choice");
                    ch1 = int.Parse(Console.ReadLine());
                    if (ch1 == 1)
                    {
                        Console.WriteLine("enter id:");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter username");
                        buser_name = Console.ReadLine();
                        Console.WriteLine("enter password");
                        password = Console.ReadLine();
                        Console.WriteLine("enter EmailId");
                        email_id = Console.ReadLine();
                        Console.WriteLine("enter mobile number");
                        mobile_no = double.Parse(Console.ReadLine());
                        Console.WriteLine("enter address");
                        address = Console.ReadLine();
                        Console.WriteLine("Registration successfull");
                        bbo.signup(id, buser_name, password, email_id, mobile_no);

                        // bbo = new BuyerBO(id, buser_name, password, mobile_no, email_id, address, CreatedDate);
                    }
                    else if (ch1 == 2)
                    {
                        bbo.CheckBuyer();
                    }
                    else
                        Console.WriteLine("wrong choice");
                    break;
                case 3:
                    Console.WriteLine("1.Sign Up\n2.Sign In");
                    Console.WriteLine("enter the choice");
                    ch1 = int.Parse(Console.ReadLine());
                    if (ch1 == 1)
                    {
                        Console.WriteLine("enter id:");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter username");
                        suser_name = Console.ReadLine();
                        Console.WriteLine("enter password");
                        password = Console.ReadLine();
                        Console.WriteLine("enter company name");
                        company_name = Console.ReadLine();
                        Console.WriteLine("enter GST");
                        GST = Console.ReadLine();
                        Console.WriteLine("enter postal address");
                        Postal_address = Console.ReadLine();
                        Console.WriteLine("enter website");
                        Website = Console.ReadLine();
                        Console.WriteLine("enter EmailId");
                        email_id = Console.ReadLine();
                        Console.WriteLine("enter contact number");
                        contact_no = double.Parse(Console.ReadLine());
                        Console.WriteLine("Registration successfull");
                        sbo = new SellerBO(id, suser_name, password, company_name, GST, Postal_address, Website, email_id, contact_no);
                    }
                    else if (ch1 == 2)
                    {
                        if (sbo.CheckSeller())
                        {
                            Console.WriteLine("1.Add Item\n2.Remove Item");
                            Console.WriteLine("enter the choice");
                            int ch2 = int.Parse(Console.ReadLine());
                            switch (ch2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("1.AddItems\n2.ViewItems\n0.Back To Login");
                                        Console.WriteLine("Enter your Choice...");
                                        int bch = int.Parse(Console.ReadLine());
                                        ItemBO ibo = new ItemBO();
                                        int d, d1;
                                        switch (bch)
                                        {

                                            case 1:
                                                Console.WriteLine("Enter Items by Category and Subcatogery Wise..");
                                                Console.WriteLine("1.Add Category and Subcategory\n2.Add Product");
                                                int ad = int.Parse(Console.ReadLine());
                                                if (ad == 1)
                                                {
                                                    Console.WriteLine("Enter Category id Which u want to add");
                                                    d = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("Enter Category Name ..");
                                                    string cnam = Console.ReadLine();

                                                    Console.WriteLine("Enter sub Category id Which u want to add");
                                                    d1 = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("Enter Subcatogery Name..");
                                                    string sc_name = Console.ReadLine();
                                                    Console.WriteLine("Enter Details about Subcatogery..");
                                                    string des1 = Console.ReadLine();
                                                    ibo.AddCatandSubcategory(d, cnam, d1, sc_name, des1);
                                                }

                                                else if (ad == 2)
                                                {
                                                    Console.WriteLine("Enter Category id Which u want to add");
                                                    int d2 = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("Enter Sub Category id Which u want to add");
                                                    int d3 = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("Enter Itemid..");
                                                    int iid = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("Enter Itemname..");
                                                    string iname = Console.ReadLine();
                                                    Console.WriteLine("Enter price of The item...");
                                                    double iprice = double.Parse(Console.ReadLine());

                                                    Console.WriteLine("Enter Item Description..");
                                                    string des = Console.ReadLine();
                                                    Console.WriteLine("Enter Stock of Items..");
                                                    int st = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("Enter any remarks..");
                                                    string rem = Console.ReadLine();
                                                    Console.WriteLine("Enter any Gst % Of The Item..");
                                                    double gst = double.Parse(Console.ReadLine());
                                                    ibo.AddItems(d2, d3, iid, iprice, iname, des, st, rem,gst);
                                                }
                                                break;
                                            case 2:
                                                ibo.viewItems();
                                                break;

                                            default:
                                                Console.WriteLine("Invalid Creditianls..");
                                                break;
                                        }
                                    }
                                   
                            }
                            // so.AddItem(category_id, category_name, subcategory_id, subcategory_name, subcategory_details);
                        }
                        
                    }
                    else
                        Console.WriteLine("wrong choice");
                    break;
                case 2:
                    so.RemoveItem();
                    break;

            }

        }
    }                 
    
 }
            
        
    


//public void addItems()
//{
//    int category_id = 0;
//    string category_name = null;
//    Console.WriteLine("enter no of categories");
//    int no_of_cat = int.Parse(Console.ReadLine());
//    for (int i = 0; i < no_of_cat; i++)
//    {
//        Console.WriteLine("enter category id");
//        category_id = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter category name");
//        category_name = Console.ReadLine();
//        cat.Add(CategoryList(category_id, category_name, out int c_id));
//    }
//    Console.WriteLine("enter no of subcategories to add");
//    int subcat = int.Parse(Console.ReadLine());
//    Console.WriteLine("enter sub categories names");
//    for (int i = 0; i < subcat; i++)
//    {
//        Console.WriteLine("enter sub category name");
//        string subcategory_name = Console.ReadLine();
//        Console.WriteLine("enter sub category id");
//        int subcategory_id = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter detaisl");
//        string subcategory_details = Console.ReadLine();
//        subcatlist.Add(new SubCategory(category_id, category_name, subcategory_id, subcategory_name, subcategory_details));
//    }
//    Console.WriteLine("enter no of items to be added");
//    int item_n = int.Parse(Console.ReadLine());
//    for (int i = 0; i < item_n; i++)
//    {
//        Console.WriteLine("enter items to be added");
//        string item_name = Console.ReadLine();
//        Console.WriteLine("enter item id");
//        int item_id = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter details of item");
//        string item_det = Console.ReadLine();
//        Console.WriteLine("enter price of item");
//        double price = double.Parse(Console.ReadLine());
//        Console.WriteLine("enter ");
//    }

