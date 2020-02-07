using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
   /* class Parent
    {
        protected int a;
       protected string b;
        public int A
        {
            get => a;
            set =>a =value;
        }
        public string B
        {
            get => b;
            set => b = value;
        }
        public void getValue(int x, string y)
        {
            this.a = x;
            this.b = y;
        }
        public void display()
        {
        Console.WriteLine(this.A + " " + this.B);
        }
    }
    class Child:Parent
    {
        int c;
        public void Calculate(int num)
        {
            c = this.a+num;
            Console.WriteLine(c);
        }
    }
    class Child2:Child
    {
        int d;
        public void Add(int n3)
        {
            d=this.a=+n3;
            Console.WriteLine(d);
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            /*Child ch = new Child();
            Parent p = new Parent();
            Child2 ch2 = new Child2();
            //hello.Child3 ch3 = new hello.Child3();
            p.getValue(2, "anu");
            p.display();
            ch.getValue(3,"hello");
            ch.display();
            ch.Calculate(30);
            ch2.getValue(4, "hi");
            ch2.display();
            ch2.Calculate(20);
            ch2.Add(10);
            //ch3.exDisplay();*/
           // Vehicle v1 = new Vehicle();
           // Vehicle v = new Vehicle("red");
            Bus b = new Bus();
            Car c = new Car();

            //v.Start();
            // v.Stop();
            b.fillFuel();
            b.Start();
            b.Stop();
            b.Run();
            c.fillFuel();
            c.Start();
            c.Stop();
            c.Drive();
        }
    }
}
/*namespace hello
{
    class Child3: InheritanceDemo.Parent
    {
        public void exDisplay()
        {
            Console.WriteLine(this.a + " " + this.b);
        }
    }
}*/
