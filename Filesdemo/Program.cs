using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Filesdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"E:\c#, HandsOn\Anu");
            if(di.Exists==false)
                di.Create();
            di.CreateSubdirectory("mydir");
            DirectoryInfo[] d = di.GetDirectories();
            foreach(DirectoryInfo x in d)
            {
                Console.WriteLine(x.Name+" "+x.FullName+" "+x.CreationTime);
            }
            FileInfo[] fi = di.GetFiles();
            Console.WriteLine(".......................");
            foreach (FileInfo x in fi)
            {
                Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);
            }
           // FileStream fs = new FileStream(@"E:\c#, HandsOn\Anu\a.txt", FileMode.OpenOrCreate,FileAccess.Read);
            FileStream fs = new FileStream(@"E:\c#, HandsOn\Anu\b.txt", FileMode.OpenOrCreate, FileAccess.Write);
            /*StreamReader sr = new StreamReader(fs);
            string s;
            while((s=sr.ReadLine())!=null)
            {
                Console.WriteLine(s);
            }
            /* StreamWriter sw = new StreamWriter(fs);
             sw.WriteLine("Welocome");
             for(int i=0;i<2;i++)
             {
                 string s = Console.ReadLine();
                 sw.WriteLine(s);
             }*/
            //
            // sr.Close();
            //sw.Close();
            BinaryWriter bw = new BinaryWriter(fs);
            int i = 10;
            char ch = 'd';
            string f = "helllo";
            bw.Write(i);
            bw.Write(ch);
            bw.Write(f);
            bw.Close();
            FileStream fs1 = new FileStream(@"E:\c#, HandsOn\Anu\b.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs1);
            int x = br.Read();

            fs.Close();
        }
    }
}
