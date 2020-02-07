using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        class Cal
        {
            int val1, val2;
            public  int Val1 { get => val1; set => val1 = value; }
            public int Val2{ get => val2; set => val2 = value; }
            public Cal(int val1,int val2)
            {
                this.val1 = val1;
                this.val2 = val2;
            }
            public void Add(int num1, int num2,out int add)
            {
               add=num1 + num2;
                //Console.WriteLine("sum is:"+(num1+num2));
            }
            /*public void Swap(int n1,int n2)
            {
                n1 = n1 + n2;
                n2 = n1 - n2;
                n1 = n1 - n2;
                Console.WriteLine(n1 + " " + n2);
            }*/
            public void Swap(ref int n1,ref int n2,out int x,out int y)
            {
                n1 = n1 + n2;
                n2 = n1 - n2;
                n1 = n1 - n2;
                //Console.WriteLine(n1 + " " + n2);
                x = n1;
                y = n2;
                
              
            }

        }
        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Cal c = new Cal(n1, n2 );
            c.Add(n1, n2,out int add);
            Console.WriteLine("sum is:" +add);
            //c.Swap(n1,n2);
           c.Swap(ref n1,ref n2,out int x,out int y);
           Console.WriteLine("n1,n2:"+x+" "+y);
          
        }
    }
}
