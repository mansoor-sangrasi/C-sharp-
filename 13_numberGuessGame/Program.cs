namespace _13_numberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Guess number between 1 and 100");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int computerNum = random.Next(1, 101);


            if (userNum == computerNum)
            {
                Console.WriteLine("Correct Guess");
            }
            else if (userNum < computerNum)
            {
                Console.WriteLine("Guess Number is less than Computer Number");
            }
            else if (userNum > computerNum)
            {
                Console.WriteLine("Guess Number is greater than Computer Numnber");
            }

            while (userNum != computerNum)
            {
                Console.WriteLine("Guess number between 1 and 100");
                userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum == computerNum)
                {
                    Console.WriteLine("Correct Guess");
                }
                else if (userNum < computerNum)
                {
                    Console.WriteLine("Guess Number is less than Computer Number");
                }
                else if (userNum > computerNum)
                {
                    Console.WriteLine("Guess Number is greater than Computer Numnber");
                }
            }
        }
    }
}
