namespace _05_randomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn how to generate random number in C-sharp");

            // first of all create random object
            Random random = new Random();

            // Generate random number b/w whole number
            int randomWholeNum = random.Next(1, 7); // random num b/w 1 & 6
            Console.WriteLine(randomWholeNum);

            // Generate random number b/w decimal number
            double randomDecimalNum = random.NextDouble(); // No argument accept
            Console.WriteLine($"decimal number b/w 0 and 1 is {randomDecimalNum}");
                

        }
    }
}
