using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = null;
            Console.WriteLine("enter name:");
            Name = Console.ReadLine();
            int Year = 0;
            Console.WriteLine("enter Graduation yr:");
            Year = int.Parse(Console.ReadLine());
            Console.WriteLine("My name is "+Name+" and i will graduate in the year "+Year);
          //  Console.WriteLine("enter name:");
        }
    }
}
