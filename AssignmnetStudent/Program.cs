using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmnetStudent
{
    abstract class Student
    {
        string name;
        int studentId;
        double grade;
        public Student(string name,int studentId,double grade)
        {
            this.name = name;
            this.studentId = studentId;
            this.grade = grade;
        }
        public abstract Boolean IsPassed(double grade);


    }
    class UnderGraduate:Student
    {
        public UnderGraduate(string name, int studentId, double grade):base(name,studentId,grade)
        {
            Console.WriteLine("name:" + name + "\nstdentId:" + studentId + "\ngrade:" + grade);
        }
        public override Boolean IsPassed(double Grade)
        {
            if (Grade > 70.0)
                return true;
            else
                return false;
        
        }
    }
    class Graduate : Student
    {
        public Graduate(string name, int studentId, double grade) : base(name, studentId, grade)
        {
            Console.WriteLine("name:" + name + "\nstdentId:" + studentId + "\ngrade:" + grade);
        }
        public override Boolean IsPassed(double Grade)
        {
            if (Grade > 80.0)
                return true;
            else
                return false;

        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            
            Console.WriteLine("enter the choice:\n 1.UnderGraduate\n 2.Graduate");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the grade");
            double grd = double.Parse(Console.ReadLine());
            Student st;
            if (ch == 1)
            {
                
                st = new UnderGraduate("anu", 123, grd);
                if (st.IsPassed(grd))
                    Console.WriteLine("passed");
                else
                    Console.WriteLine("failed");
            }
            else
            {
                st = new Graduate("hello", 234, grd);
                if (st.IsPassed(grd))
                    Console.WriteLine("passed");
                else
                    Console.WriteLine("failed");
                st.IsPassed(grd);
            }

            
        }
    }
}
