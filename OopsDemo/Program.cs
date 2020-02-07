using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Student
    {
        private int rollno, mark, sem;
        string branch;
        public string Name { get; set; }
        public Student()//default Constructor
        {
            this.Name = "";
            this.Rollno = 23;
            this.Sem = 2;
            this.branch = "Cse";
        }
        public Student(string name, int no, int s, string branch)
        {
            this.Name = name;
            this.Rollno = no;
            this.Sem = s;
            this.branch = branch;
        }
        public int Rollno
        {
            get
            {
                return rollno;
            }
            set
            {
                rollno = value;
            }
        }
        public string Branch
        {


            get
            {
                return branch;
            }
            set
            {
                branch = value;
            }
        }
        public int Mark
        {


            get
            {
                return mark;
            }
        }



        public int Sem { get => sem; set => sem = value; }

        public void Accept()
        {
            Console.WriteLine("Enter the marks");
            this.mark = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the branch");
            this.branch = (Console.ReadLine());

        }
        public void Display()
        {
            Console.WriteLine("Details are displayued");
            Console.WriteLine(" the name is:" + this.Name + "\t" + "the roll no is:" + this.Rollno + " the marks :" + this.Mark + "\t" + "the brnch :" + this.Branch + "\t" + this.Sem);
            //  Console.WriteLine("the roll no is:" + rollno);
        }
        class Program
        {
            public static void Main(string[] args)
            {
                Student s = new Student();
                s.Accept();
                s.Display();

            }
        }
    }
}

