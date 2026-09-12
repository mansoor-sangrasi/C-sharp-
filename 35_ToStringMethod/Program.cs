namespace _35_ToStringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ToString() => convert object to string representation that is suitable
            // for display.

            Car car = new Car("Honda", "Civic", 2026);

            Console.WriteLine(car);
        }
    }

    class Car
    {
         String make;
         String model;
         int year;

        public Car(String make, String model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;

        }

        public override string ToString()
        {
            String message = $"This is a {make} {model}";
            return message;
        }
    }
}
