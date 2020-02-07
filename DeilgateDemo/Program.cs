using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeilgateDemo
{
    public delegate void deligatePointer();
    public delegate double Caldelegatepointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("hello world");
             Program p = new Program(); 
             deligatePointer mydeligate = p.print;
             mydeligate();
             CalAreaPointer cptr = Calculate.calArea;
             double area== cptr(12); 
        \ }
         public void print()
         {
             Console.WriteLine("welcome to deligate");
         }
         public void calArea()
         {

         }
         public void Calculate()
         {

         }
            //caldelegatepointer cptr = new caldelegatepointer(calarea);
            //double area = cptr(12);
            //Console.WriteLine(area);
            //Console.ReadKey();
            Caldelegatepointer cptr = new Caldelegatepointer(delegate (double r)
            {
                return 3.14 * r * r;
            });
            double area = cptr(12);
            Console.WriteLine(area);


            Caldelegatepointer cptr1 = (r => 3.14 * r * r);
            double area1 = cptr1(10);
            Console.WriteLine(area1);
        }
        //public static double calarea(double a)
        //{
        //    return a * a;
            //caldelegatepointer cptr = new caldelegatepointer(calarea);
            //double area = cptr(12);
            //Console.WriteLine(area);
            //Console.ReadKey();
            Caldelegatepointer cptr = new Caldelegatepointer(delegate (double r)
            {
                return 3.14 * r * r;
            });
            double area = cptr(12);
            Console.WriteLine(area);


            Caldelegatepointer cptr1 = (r => 3.14 * r * r);
            double area1 = cptr1(10);
            Console.WriteLine(area1);

            //function delegate

            Func<double, double> f1 = (r => 3.14 * r * r);
            double a = f1(3);
            Console.WriteLine(a);

            //Action delegate

            Action<string> act = (x => Console.WriteLine(x));
            act("4");

            //predicate
            Predicate<string> pt = (y => y.Length > 3);
            Console.WriteLine(pt("cts"));

            int[] A = new int[5] { 1, 2, 3, 4, 5 };
            int y1 = A.Count(x => x > 2);
            Console.WriteLine(y1);
            List<string> l = new List<string>();
            l.Add("anjhjb");
            //public static double calarea(double a)
            //{
            //    return a * a;
            //}
    }*/
            //caldelegatepointer cptr = new caldelegatepointer(calarea);
            //double area = cptr(12);
            //Console.WriteLine(area);
            //Console.ReadKey();
            Caldelegatepointer cptr = new Caldelegatepointer(delegate (double r)
            {
                return 3.14 * r * r;
            });
            double area = cptr(12);
            Console.WriteLine(area);


            Caldelegatepointer cptr1 = (r => 3.14 * r * r);
            double area1 = cptr1(10);
            Console.WriteLine(area1);

            //function delegate

            Func<double, double> f1 = (r => 3.14 * r * r);
            double a = f1(3);
            Console.WriteLine(a);

            //Action delegate

            Action<string> act = (x => Console.WriteLine(x));
            act("4");

            //predicate
            Predicate<string> pt = (y => y.Length > 3);
            Console.WriteLine(pt("cts"));

            int[] A = new int[5] { 1, 2, 3, 4, 5 };
            int x1 = A.Count(x => x > 2);
            Console.WriteLine(x1);
            List<string> l = new List<string>();
            l.Add("chinni");
            l.Add("chinnu");
            l.Add("Bannu");
            List<string> s = l.FindAll(y => y.Contains('n'));
            foreach (string n in s)
            {
                Console.WriteLine(n);
            }
            //public static double calarea(double a)
            //{
            //    return a * a;
            //}
        }
    }
}

