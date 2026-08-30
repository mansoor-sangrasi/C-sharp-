namespace _22_exceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exception => Errors that occur during execution.

            // try => try some code which is consider dangerous.
            // catch => catches and handles exceptions when they occur.
            // finally => always execute if exception is caught or not.


            double x;
            double y;
            double z;
            try
            {
                Console.Write("Enter value of x:");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter value of y:");
                y = Convert.ToDouble(Console.ReadLine());

                z = x / y;

                Console.WriteLine($"Result: {z}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter only number");

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Zero can't be divided");
                
            }
            finally
            {
                Console.WriteLine("Thanks for learning exception handling");
            }



        }
    }
}
