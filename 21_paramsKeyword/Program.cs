namespace _21_paramsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // params keyword => With the help of params keyword a single 
            // function can takes multiple argument in form of single dimensional
            // array.
            // it's avoid function overloading.

            totalPrice(200, 300, 500); // => method invoked
        }
        static void totalPrice (params int[] prices)
        {
            int total = 0;
            for (int i=0; i<prices.Length; i++)
            {
                total += prices[i];

            }
            Console.WriteLine($"TotalPrice = {total}");

        }
    }
}
