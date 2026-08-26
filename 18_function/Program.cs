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

            singHappyBirthDay(name);
            singHappyBirthDay(name1);
        }

        static void singHappyBirthDay (String name)
        {
            Console.WriteLine("Happy BirthDay");
            Console.WriteLine(name);

        }
    }
}
