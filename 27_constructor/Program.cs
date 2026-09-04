namespace _27_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constructor => A special method in class having same name
            // can be used to assign argument when creating the object.

            Car car1 = new Car("Honda", "City", 2026, "Black");
            Car car2 = new Car("Honda","Swift",2024,"White");

            
            car1.drive();
            car2.drive();
        }
    }

    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car (String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;

        }

        public void drive ()
        {
            Console.WriteLine($"You drive the {make} {model}");
        }
    }
}
