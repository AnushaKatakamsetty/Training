using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack slist = new Stack();
            slist.Push(20);
           foreach(var i in slist) Console.WriteLine(i);
            Hashtable ht = new Hashtable();
            ht.Add(1, "CTS");
            ht.Add('a', "anu");
            foreach (var i in ht.Keys) Console.WriteLine(i+" "+ht[i]);
            List<int> ls = new List<int>();
            ls.Add(20);
            ls.Add('a');
            foreach (var i in ls) Console.WriteLine(i);
            Stack<String> gslist = new Stack<string>();
            gslist.Push("hello");
            foreach (var i in gslist) Console.WriteLine(i);

        }

    }
}
