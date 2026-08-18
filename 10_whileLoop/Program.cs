namespace _10_whileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // while loop => repeat some code when condition will true

            Console.WriteLine("Learn about while loop");

            Console.Write("Enter your name:");
            String name = Console.ReadLine();
            while (name == "")
            {
                Console.Write("Enter your name:");
                 name = Console.ReadLine();

            }
            Console.WriteLine("Welcome " + name);

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"Value of i is {i}");
                i++;
            }
        }
    }
}
