using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[2][];
           
            for (int i= 0; i < 2; i++)
            {
                Console.WriteLine("enter size:");
                int size = Convert.ToInt32(Console.ReadLine());
                array[i]= new int[size];
            }
            for (int row = 0; row < 2; row++)
                for (int col = 0; col < array[row].Length; col++)
                {
                    array[row][col] = Convert.ToInt32(Console.ReadLine());
                }
            int sum = 0;
            int count = 0, b = 0;
            //int[] sumA = new int[20];
            foreach (int x in array)
            {

                int temp =x;
                
                for (int row = 0; row < 2; row++)
                {
                    for (int col = 0; col < array[row].Length; col++)
                    {



                        //for (int y = 0; y < array[row].Length; y++)
                        //{ 
                        if (array[row][col] == temp)
                            count = count + 1;
                    }
                }
                if (count > 0)
                    sum = sum + x;
                   
            }
            Console.WriteLine("sum is:" + sum);
        }
    }
}
