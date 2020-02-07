using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDemo
{
    interface ifactory
    {
        void Manufacture(int cnt);

    }
    class Bike : ifactory
    {
        public void Manufacture(int cnt)
        {
            Console.WriteLine("manufacturing No: " + cnt);
        }
    }

    class car : ifactory
    {
        public void Manufacture(int cnt)
        {
            Console.WriteLine("manufacturing No: " + cnt);
        }
    }
    abstract class VehicleFactory
    {
        public abstract ifactory generateVehicles(string type);
    }

    class ConcreteVehicleFactory : VehicleFactory
    {
        public override ifactory generateVehicles(string type)
        {
            if (type == "Bike") return new Bike();
            else return new car();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vf = new ConcreteVehicleFactory();
            ifactory myvehicle = vf.generateVehicles("Bike");
            myvehicle.Manufacture(10);
            myvehicle = vf.generateVehicles("car");
            myvehicle.Manufacture(10);
        }
    }
}
