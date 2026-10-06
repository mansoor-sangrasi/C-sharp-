namespace _18_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* function => perform section of code whenever it's called invoked method
             * it's benefit to reuse of code without writing the code */

            String name = "Mansoor Ahmed";
            String name1 = "Abdul Kareem";
            String name2 = "Tufail Ahmed";
            String name3 = "Tofique Ahmed";
            String name4 = "Mehtab Ali";

            printMessage();
            printName("Muhammad Siddique");
            printName("Abdul Kareem");
            printName("Majid Ali");
            printName("Huzaifa");
            printName("Bilal");
            printName("Abid Ali");  
            printName("Nisar");
            singHappyBirthDay(name);
            singHappyBirthDay(name1);
            singHappyBirthDay(name2);
            singHappyBirthDay(name3);
            singHappyBirthDay(name4);
            greeting();

            Console.ReadKey();
        }
        static void printMessage()
        {
            Console.WriteLine("Hello World");
        }
        static void printName(string name)
        {
            Console.WriteLine(name);
        }

        static void singHappyBirthDay (String name)
        {
            Console.WriteLine("Happy BirthDay");
            Console.WriteLine(name);

        }
        static void greeting()
        {
            Console.WriteLine("Welcome");
        }
    }
}
