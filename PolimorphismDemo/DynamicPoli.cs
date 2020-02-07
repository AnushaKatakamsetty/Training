using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismDemo
{
   abstract class DynamicPoli
    {
        public abstract void display();
       /* {
            Console.WriteLine("display DynamicPoli class details");
        }*/
    }
    class B:DynamicPoli
    {
        public override void display()
        {
            Console.WriteLine("display  B class details");
        }
    }
    class C:DynamicPoli
    {
        public override void display()
        {
            Console.WriteLine("display  C class details");
        }
    }
}
i