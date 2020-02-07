using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num / 2);
                try
                {
                    int[] a = new int[] { 1,2,3,4,5};
                    Console.WriteLine(a[6]);
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message+" "+e.Source+" "+e.StackTrace);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            }
        }
    }
}
