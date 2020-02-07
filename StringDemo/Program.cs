using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringDemo
{
    class Employee
    {
        string name;
        string empId;
        int slalary;
        public Employee(string name,string empId,int slalary)
        {
            ```````
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "welcome",str2="to CTS",str3="WELcome";

            Console.WriteLine("str length:" + str.Length + "\naftr replecing e with k:" + str.Replace("e", "k"));
            Console.WriteLine(String.Compare("hello","Hello")+"\n"+(String.Concat(str,str2)));
            Console.WriteLine(str.Equals(str3,StringComparison.InvariantCultureIgnoreCase));
            Console.W
        }
    }

}
