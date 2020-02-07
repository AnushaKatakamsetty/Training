using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismDemo
{
    class Shape
    {
        int length, width, breadth;
        public void draw()
        {
            Console.WriteLine("A shape can be drawn");
        }
        public void draw(int l)
        {
            Console.WriteLine("A square can be drawn");
        }
        public void draw(int l,int w )
        {
            Console.WriteLine("A rectangle can be drawn");
        }
        public void draw(int l,int w,int b)
        {
            Console.WriteLine("A box can be drawn");
        }
        public void draw(int l,int w,int b,string name)
        {
            Console.WriteLine(name+" can be drawn");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Shape pic = new Shape();
             pic.draw();
             pic.draw(10);
             pic.draw(12,14,20,"anu");
         */
            // DynamicPoli d = new DynamicPoli();
            //d.display();
            //B b = new B();
            // b.display();
            DynamicPoli d;
           // C c = new C();
            //c.display();
            d = new C();
            d.display();
        }
    }
}
