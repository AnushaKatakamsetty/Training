using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartCaseStudy
{
    class Admin
    {
        string user_name;
        string password;
        public Admin()
        { 
        }
        public void CheckUser()
        {
            Console.WriteLine("enter username");
            user_name = Console.ReadLine();
            Console.WriteLine("enter password");
            password = Console.ReadLine();
            if(user_name=="admin"&&password=="admin")
                Console.WriteLine("login successfull");
            else if(user_name == "admin"||password == "admin")
                Console.WriteLine("incorrect username or password");
            else
                Console.WriteLine("invalid user");
        }
    }
}
