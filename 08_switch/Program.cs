using System.Diagnostics;
using System.Linq.Expressions;

namespace _08_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn about Switch in C-sharp");

            Console.WriteLine("What is Today day");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day){
                case 1:
                    Console.WriteLine("Today is Monday");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Please provide valid day");
                   break;


            }
        }
    }
}
