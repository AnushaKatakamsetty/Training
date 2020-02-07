using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns
{
   sealed class Singleton
    {
        static int count = 0;
        static Singleton Instance=null;
        public static Singleton GetInstance
        {
            get
            {
                if (Instance == null)
                    return new Singleton();
                else
                    return Instance;
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine(count);
        }
        public void printDetails(string str)
        {
            Console.WriteLine("printing:"+str);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance;
            s1.printDetails("employee");



        }
    }
}
