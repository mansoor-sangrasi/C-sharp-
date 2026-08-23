namespace _15_calculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            String playAgain;
            do
            {
                Console.Write("Enter Number 1:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Number 2:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Operator +,-,x,/:");
                char operation = Convert.ToChar(Console.ReadLine());

                switch (operation)
                {

                    case '+':
                        Console.WriteLine($"Addition: {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"Subtraction: {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"Multiplication: {num1 * num2}");
                        break;
                    case '/':
                        double divide = (double)num1 / num2;
                        Console.WriteLine($"Division {divide}");
                        break;
                    default:
                        Console.WriteLine("Not valid operation");
                        break;
                }

                Console.Write("Would you like to playAgain Y/N:");
                 playAgain = Console.ReadLine();
                playAgain = playAgain.ToUpper();

            } while (playAgain == "Y");

            Console.WriteLine("Bye");




            
        }
    }
}
