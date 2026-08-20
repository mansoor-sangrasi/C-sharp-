namespace _12_nestedLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nested loop => loop inside of other loop
            // it is used in sorting algorithm
            Console.WriteLine("Learn nested loop in C-sharp");

            Console.Write("How many row in rectangle:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many column in rectangle:");
            int column = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=row; i++)
            {
                for (int j=1; j<=column; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();

            }


        }
    }
}
