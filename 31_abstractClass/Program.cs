namespace _31_abstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // abstract class => Modifier that indicate missing component and 
            // incomplete implementation .
            // class having no object.


            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();
            
          
            
        }
    }

   abstract class Vehicle
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
       public int maxSpeed = 200;
    }

    class Bike : Vehicle
    {
        public int wheel = 2;
       public int maxSpeed = 120;
    }

    class Boat : Vehicle
    {
        public int wheel = 0;
       public int maxSpeed = 150;
    }
}


