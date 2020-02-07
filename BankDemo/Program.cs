using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{ 
    interface Iloan
    {
         void getInterest();
    }
    abstract class Bank
    {
        protected string BankName;
        protected string location;
        public Bank(string name,string location)
        {
            this.BankName = name;
            this.location = location;
        }
    }
    class SBI:Bank,Iloan
    {
        string bManager;
        public SBI(string name, string location,string manager):base(name,location)
        {
            this.bManager = manager;
        }
        public void getInterest()
        {
            Console.WriteLine("SBI interest rate is 5%");
        }
        public void displayDetails()
        {
            Console.WriteLine("name:" + BankName + "\nlocation:" + location + "\nmanager:" + bManager);
        }
    }
    class ICICI: Bank,Iloan
    {
        string bManager;
        public ICICI(string name, string location, string manager) : base(name, location)
        {
            this.bManager = manager;
        }
        public void getInterest()
        {
            Console.WriteLine("SBI interest rate is 15%");
        }
        public void displayDetails()
        {
            Console.WriteLine("name:" + BankName + "\nlocation:" + location + "\nmanager:" + bManager);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICICI ic = new ICICI("anu", "chennai", "vishnu");
            SBI sb = new SBI("anusha", "hyd", "balu");
            ic.displayDetails();
            ic.getInterest();
            sb.displayDetails();
            sb.getInterest();
        }
    }
}
