using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnIndex
{
    class Car
    {
        int year;
        string[] name = new string[4];

        public int Year { get => year; set => year = value; }
        // public string[] Name { get => name; set => name = value; }

        public string this[int x]
        {
            get
            {
                return name[x];
            }
            set
            {
                name[x] = value;
            }
        }
        public void display()
        {
            Console.WriteLine(year);
            foreach (string x in name)
                Console.WriteLine(x);
        }
    }
    class Programlkafdleaalfealj
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Year = 2019;
            c[0] = "duster";
            c[1] = "swift";
            c[2] = "kia";
            c.display();
            // string[] ar = new string[] { "swift", "climber };
            Console.ReadKey();

        }
    }
}
