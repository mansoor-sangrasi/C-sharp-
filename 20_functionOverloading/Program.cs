namespace _20_functionOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // function overloading => functions having same name and behavoir
            // but different in parameter.
            // name + parameter = signature
            // unique signature

            Addition(3, 2);
            Addition(10, 12, 3);
            Addition(20, 30, 40,20);
        }

        static void Addition (int x, int y)
        {
            Console.WriteLine($"Addition result {x + y}");

        }
        static void Addition (int x, int y, int z)
        {
            Console.WriteLine($"Addition result {x + y + z}");

        }
        static void Addition (int a, int b, int c, int d)
        {
            Console.WriteLine($"Addition result {a + b + c + d}");

        }

    }
}
