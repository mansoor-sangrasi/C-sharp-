namespace _19_returnFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // return => Return back data where method is invoked

            int x;
            int y;
            int result;

            Console.Write("Enter value of x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y:");
            y = Convert.ToInt32(Console.ReadLine());

             result = Addition(x, y);
            Console.WriteLine($"Addition result : {result}");
        }
        static int Addition (int x, int y)
        {
            int z = x + y;
            return z;
        }
    }
}
