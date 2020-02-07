using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size:");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size % 2 == 0)
            {
                Console.WriteLine("entered size is even re-enter odd size:");
                 size = Convert.ToInt32(Console.ReadLine());
            }
            int[] array = new int[size];
            Console.WriteLine("enter elements:");
            for (int i = 0; i < size; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());
            if (size == 1)
                Console.WriteLine("largest is:" + array[0]);
            else
            {
                int start= array[0],middle = array[(size) / 2], end = array[size - 1];
                int largest = ((start > middle) && (start > end)) ? start : ((middle > end) ? middle : end);
                Console.WriteLine("largest is :" + largest);
            }
        }
    }
}
