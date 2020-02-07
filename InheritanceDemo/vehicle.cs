using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
   abstract class Vehicle
    {
        protected string color;
        public Vehicle()
        {
            this.color = "royal blue";
            Console.WriteLine(color);
        }
        public Vehicle(string color)
        {
            this.color = color;
            Console.WriteLine(color);
        }
        abstract public void fillFuel();
        public void Start()
        {
            Console.WriteLine("Vehicle started:");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Vehicle stopped:");
        }
    }
    class Bus:Vehicle
    {
        int seating;
        int speed;
        public Bus():base("green")
        {
            this.seating = 60;
            this.speed = 120;
            Console.WriteLine("seating:" + seating + " speed:" + speed);
        }
        public override void fillFuel()
        {
            Console.WriteLine("fill the petrol");
        }
        public override void Stop()
        {
            Console.WriteLine("bus  stopped:");
        }
        public void Run()
        {
            Console.WriteLine("bus is running:");
        }
    }
    class Car:Vehicle
    {
        public override void fillFuel()
        {
            Console.WriteLine("fill the deisel");
        }
        public void Drive()
        {
            Console.WriteLine("Driver is driving the car:");
        }

    }
}
