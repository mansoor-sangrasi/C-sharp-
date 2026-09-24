namespace _47_actionDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // action delegate is used for void type method
            Action<int, int> actionDelegate = multiply;
            actionDelegate(10, 2);
        }

        public static void multiply(int a, int b)
        {
            Console.WriteLine($"Multiplication : {a * b}");

        }
    }
}
