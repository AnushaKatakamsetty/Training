using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPoliAssi
{
    class Delivery
    {
       public void DisplayDeliveryDetails()
        {

        }
        public void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("bowler:" + bowler + "\t batsman:" + batsman);
        }
        public void DisplayDeliveryDetails(long runs)
        {
            if (runs == 6 || runs == 4)
                Console.WriteLine("it is " + runs);
            else
                Console.WriteLine("runs:"+runs);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Delivery dv = new Delivery();
            Console.WriteLine("menu\n1.playerdetails of the delivery\n2.run details of the delivery \n enter choice:");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("enter the bowler name ");
                string bowlername = Console.ReadLine();
                Console.WriteLine("enter the batsman name ");
                string batsmanname = Console.ReadLine();
                dv.DisplayDeliveryDetails(bowlername, batsmanname);
            }
            else if(ch==2)
            {
                Console.WriteLine("enter runs ");
                int runs = Convert.ToInt32(Console.ReadLine());
                dv.DisplayDeliveryDetails(runs);
            }
            else
                Console.WriteLine("invalid choice ");
        }
    }
}
