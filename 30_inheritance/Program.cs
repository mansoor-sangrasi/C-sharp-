using System.Security.Cryptography;

namespace _30_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inheritance => 1 and more child class recieve fields and methods
            // from common parent.

            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();

            Console.WriteLine("Car Detail");
            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheel);
            car.go();

            Console.WriteLine("Bike Detail");
            Console.WriteLine(bike.speed);
            Console.WriteLine(bike.wheel);
            bike.go();

            Console.WriteLine("Boat Detail");
            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheel);
            boat.go();
        }
    }
    
    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car : Vehicle
    {
        public int wheel = 4;
    }

    class Bike : Vehicle
    {
        public int wheel = 2;
    }

    class Boat : Vehicle
    {
        public int wheel = 0;
    }
}
