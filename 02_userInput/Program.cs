namespace _02_userInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn about user input");

            // Console.ReadLine() => Input leta hn or string return krta hn

            Console.WriteLine("What's your name?");
            String name = Console.ReadLine();

            Console.WriteLine("What's your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {name} and you are {age} year old ");
        }
    }
}
