namespace _09_logicalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // logical operator is used to check more than one condition
            // AND &&
            // OR ||

            Console.WriteLine("Learn about logical operator");

            Console.WriteLine("Enter Temperatur:");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp>=0 && temp<=35)
            {
                Console.WriteLine("Today weather was cool");
            }
            else if (temp>=36)
            {
                Console.WriteLine("Today weather was hot");
            }
        }
    }
}
