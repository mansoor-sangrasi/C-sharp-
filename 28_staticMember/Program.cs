namespace _28_staticMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static => Modifier to declare static member which belong to class
            // itself rather than any specific object.

            RacingCar car1 = new RacingCar("Swift");
            RacingCar car2 = new RacingCar("Cultus");
            RacingCar car3 = new RacingCar("City");
            RacingCar car4 = new RacingCar("Fortuner");

            RacingCar.totalCar();
          
        }

        class RacingCar
        {
            public String model;
           public static int numberOfCar;

            public RacingCar (String m)
            {
                model = m;
                numberOfCar++;

            }
            public static void totalCar ()
            {
                Console.WriteLine($"Total Car: {numberOfCar}");
            }
        }
    }
}
