using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostlerOrDays
{
   abstract class Student
    {
        int stdid;
        string stdname;
        double examfee;
        public Student()
        {

        }
        public void displayDetails()
        {

        }
        public abstract double payfee();
    }
    class Dayscholar:Student
    {
       
        double transportfee;
        public Dayscholar(double transportfee)
        {
            this.transportfee = transportfee;
        }
        public override double payfee()
        {
            throw new NotImplementedException();

            double total;
            total = (examfee + transportfee);
            return total;
        }

    }
    class Hostler:Student
    {
        double hostelfee;
        public Hostler(double hostelfee)
        {
            this.hostelfee = hostelfee;
        }
        public override double payfee()
        {
            throw new NotImplementedException();


            double total;
            total = (examfee + hostelfee);
            return total;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
