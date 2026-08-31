namespace _23_ternaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ternary operator or conditional operator
            // (condition) ? true statement : false statement;

            int temperature = 20;
            String message;

            message = (temperature >= 15) ? "it's warm outside" : "it's cool outside";
            Console.WriteLine(message);
        }
    }
}
