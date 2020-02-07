using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMVC.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Amount { get; set; }
        public Customer()
        { }
        public Customer(int ID,string Name,string Email,int Amount)
        {
            this.ID = ID;
            this.Name = Name;
            this.Email = Email;
            this.Amount = Amount;
        }
    }
   
}
