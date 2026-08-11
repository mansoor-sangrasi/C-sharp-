namespace _03_arithmeticOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn simple arithmetic operator");

            // Plus Operator:

            int x = 71;
            // Increment way
            x = x + 1;
            x += 1;
            x++;
            Console.WriteLine($"Value of x is {x}");

            // Minus Operator:

            int y = 19;
            // Decrement way
            y = y - 1;
            y -= 1;
            y--;
            Console.WriteLine($"Value of y is {y}");

            // Multiply Operator:

            int z = 10;
            // Multiply way
            z = z * 2;
            z *= 2;
            // z * * ; ye cheez C# ma exist nhi krti 
            Console.WriteLine($"Value of z is {z}");

            // Division Operator:

            double a = 10;
            // Division way
            a = a / 2;
            a /= 2;
            Console.WriteLine($"Value of a is {a}");

            // Modulus Operator:

            int b = 11;
            int reminder = b % 2;
            Console.WriteLine($"Reminder of b is {reminder}");


        }
    }
}
