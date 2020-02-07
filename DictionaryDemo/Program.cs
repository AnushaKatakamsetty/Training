using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DictionaryDemo
{
    class Program
    {
        /*public static  Read(int size)
        {
            int name,value,key,i, sal;
            for (i = 0; i < size; i++)
            {
                Console.WriteLine("enter key:")
                key=Console.ReadLine();
                Console.WriteLine("enter value:");
                value = Convert.ToInt32(Console.ReadLine());
              
            }
        }*/
        static void Main(string[] args)
        {
            Dictionary<string,int> dt = new Dictionary<string,int>();
            Console.WriteLine("enter size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int sal;
            String name;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter name:");
                name = Console.ReadLine();
                Console.WriteLine("enter sal:");
                sal = Convert.ToInt32(Console.ReadLine());
                dt.Add(name, sal);
            }
            foreach(KeyValuePair<string,int> j in dt)
                Console.WriteLine(j);
            int highSal = 0;
            string hname=null;
            foreach(KeyValuePair<string, int> k in dt)
            if (k.Value> highSal)
            {
                highSal= k.Value;
                hname = k.Key;
            }
            Console.WriteLine("high sal for:" + hname + "and sal is" + highSal);
        }
    }
}
