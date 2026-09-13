using System.Runtime.CompilerServices;

namespace _36_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // polymorphism => It is a greek word having many form
           // object can be identified by more than one form
           // Ex Dog is : Animal,Canine,Organism

            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();

            Vehicle[] vehicles = { car, bike, boat };

            for(int i=0; i<vehicles.Length; i++)
            {
                vehicles[i].Move();

            }
        }

    }

    class Vehicle
    {
        public virtual void Move()
        {

        }

    }

    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Car is Moving");
        }

    }

    class Bike : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Bike is Moving");
        }

    }

    class Boat : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Boat is Moving");
        }

    }
}
