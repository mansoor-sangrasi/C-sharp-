namespace _07_conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn Condition in C-sharp");

            // Program 1
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are Adult");
            }
            else if (age <= 0)
            {
                Console.WriteLine("This is not valid age");
            }
            else {
                Console.WriteLine("You are Minor");
            }

            // Program 2
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You did not enter your name");
            }
            else
            {
                Console.WriteLine($"Hello {name}");
            }






        }
    }
}
