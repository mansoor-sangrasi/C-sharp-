namespace _04_mathFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn about math function");

            // 1) Math.Pow(base,exponent) => return type double
            int a = 3;
            int b = 2;
            int a_pow_b = Convert.ToInt32(Math.Pow(a,b));
            Console.WriteLine($"3 raise to power 2 is {a_pow_b} ");

            // 2) Math.Sqrt(num)  => return type double 
            int c = 4;
            int d = Convert.ToInt32(Math.Sqrt(c));
            Console.WriteLine($"Square root of 4 is {d}");

            // 3) Math.Abs(num)
            int e = -71;
            int f = Math.Abs(e);
            Console.WriteLine($"Absolute value of -71 is {f}");

            // 4) Math.Round(num)  => return type double
            double g = 3.4;
            int h = Convert.ToInt32(Math.Round(g));
            Console.WriteLine($"Round of value of 3.4 is {h}");

            // 5) Math.Ceiling(num)  => return type double
            double i = 0.001;
            int j = Convert.ToInt32(Math.Ceiling(i));
            Console.WriteLine($"Ceiling value of 0.001 is {j}");

            // 6) Math.Floor(num)  => return type double
            double k = 7.99;
            int l = Convert.ToInt32(Math.Floor(k));
            Console.WriteLine($"Floor value of 7.99 is {l}");

            // 7) Math.Max(num1,num2)
            int m = 71;
            int n = 72;
            int o = Math.Max(m, n);
            Console.WriteLine($"Maximum value b/w 71 & 72 is {o}");

            // 8) Math.Min(num1,num2)
            int p = 71;
            int q = 72;
            int r = Math.Min(p, q);
            Console.WriteLine($"Minimum value b/w 71 & 72 is {r}");

            Console.WriteLine("Calculate Hypotenuse");
            // formula => C = sqrt(A^2 + B^2)

            Console.WriteLine("Enter Side A:");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Side B:");
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
            Console.WriteLine($"Value of Side C is {C}");







        }
    }
}
