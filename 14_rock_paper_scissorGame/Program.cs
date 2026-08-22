namespace _14_rock_paper_scissorGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any one of them:");
            Console.WriteLine("1: Rock");
            Console.WriteLine("2: Paper");
            Console.WriteLine("3: Scissor");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            if (userChoice == computerChoice)
            {
                Console.WriteLine("Match will be draw");
            }
            else if ( (userChoice==1 && computerChoice==3) || (userChoice==2 && computerChoice==1) || (userChoice==3 && computerChoice==2))
            {
                Console.WriteLine("User Win");

            }
            else if (userChoice<1 || userChoice>3)
            {
                Console.WriteLine("Invalid Choice");

            }
            else
            {
                Console.WriteLine("Computer Win");
            }

            
        }
    }
}
