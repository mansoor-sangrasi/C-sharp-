namespace _01_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn Variables");

            int x; // declaration
            x = 25; // initialization

            int y = 71; // declaration + initialization

            int z = x + y;

            Console.WriteLine($"Value of x is {x}"); // string-interpolation in C-sharp
            Console.WriteLine("Value of y is " + y); // string concatination
            Console.WriteLine("Value of z is {0}", z); // composite formating purana tareeqa

            String name = "Mansoor Ahmed";
            int age = 19;
            double height = 5.7;
            char name_char = 'M';
            bool alive = true;

            Console.WriteLine($"My name is {name} and I am {age} year old and my height is {height} my name first letter is {name_char} I am alive {alive}");

            /* Constant => Immutable value which are known at compile time and do not 
             * change in life of the program*/

            const double pi = 3.14;

            Console.WriteLine(pi);

            // TypeCasting => A process in which we convert one data type to another

            Console.WriteLine("Learn about typeCasting");

            // Convert int to double

            int a = 71;
            double b = Convert.ToDouble(a);
            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            // Convert double to int

            double c = 25.3;
            int d = Convert.ToInt32(c);

            Console.WriteLine(d);
            Console.WriteLine(d.GetType());


            // Convert int to string

            int e = 19;
            String f = Convert.ToString(e);
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            // Convert string to char

            String g = "M";
            char h = Convert.ToChar(g);
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());

            // Convert string to boolean

            String i = "True";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j);
            Console.WriteLine(j.GetType());

            

            
        }
    }
}
