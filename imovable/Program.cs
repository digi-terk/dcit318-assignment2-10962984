// See https://aka.ms/new-console-template for more information
using System;

namespace OOPDemo
{
    // Interface
    interface IMovable
    {
        void Move();
    }

    // Class implementing the interface
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Another class implementing the interface
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            car.Move();        // Output: Car is moving
            bicycle.Move();    // Output: Bicycle is moving
        }
    }
}

