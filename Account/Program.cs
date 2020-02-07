using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Acc
    {
        int accNo;
        static string bankname;
        string name;
       // public string transType;
        int balance;
        int amount;
        static Acc()
        {
            bankname = "ICICI";
        }
        public Acc(int a, int bal, string b)
        {
            this.accNo = a;
            this.name = b;
            //this.transType = c;
            this.balance = bal;
            //this.amount = amt;
        }
            public void Debit(int amt)
            {
            this.amount = amt;
                Console.WriteLine("balance aftr debitted= " + (balance - amount));
            }
            public void Credit(int amt)
            {
            this.amount = amt;
                Console.WriteLine("balance aftr creditted= " + (balance + amount));
            }
        public void display()
        {
            Console.WriteLine("Bank name is:" + bankname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*int accNo=Convert.ToInt32(Console.ReadLine());
            string name=Console.ReadLine();
            string transType=Console.ReadLine();*/
            Console.WriteLine("enter acc num:");
            int accnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter total balance:");
            int totalBal= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer name:");
            string custName = Console.ReadLine();
            Console.WriteLine("enter transaction type:");
           string type = Console.ReadLine();
            Acc acc = new Acc(accnum,totalBal,custName);
            if (type == "d" || type == "D")
            {
                Console.WriteLine("enter amount to debit:");
                int amn = Convert.ToInt32(Console.ReadLine());
                acc.Debit(amn);
            }
            else if (type == "c" || type == "C")
            {
                Console.WriteLine("enter amount to credit:");
                int am = Convert.ToInt32(Console.ReadLine());
                acc.Credit(am);7
            }
            else
                Console.WriteLine("invalid transaction");

            acc.display();
        }
    }
}
