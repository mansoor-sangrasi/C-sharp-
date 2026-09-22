using static _45_delegate.Class1;

namespace _45_delegate
{
    class Program
    {
        public delegate void print1_Delegate();

        // delegate with parameter
        public delegate void print2_Delegate(String msg);

        // delegate with parameter having return type
        public delegate int calculate_Delegate(int a, int b);

        // delegate with lambda expression
        public delegate void delegateMessage(String msg);
        static void Main(string[] args)
        {
            // Delegate is a reference to a method like pointer in C++
            // for static method delegate encapsulate method only
            // for instance method delegate encapsulate method and instance both

            print1_Delegate del1 = print1;
            print2_Delegate del2 = print2;
            calculate_Delegate del3 = calculateAddition;

            Class1.print1_Execute(del1);
            Class1.print2_Execute(del2);
            Class1.calculateAddition_Execute(del3);

            // delegate with lambda expression
            delegateMessage del4 = msg => { Console.WriteLine(msg); };
            del4("Hello World");

        }

        private static void print1()
        {
            Console.WriteLine("Method 1 having name print1");
        }

        private static void print2(String msg)
        {
            Console.WriteLine(msg);
        }

        private static int calculateAddition(int a, int b)
        {
            return a + b;

        }
    }

    class Class1
    {
        public static void print1_Execute(Program.print1_Delegate del1)
        {
            del1();

        }

        public static void print2_Execute(Program.print2_Delegate del2)
        {
            del2("Delegate with parameter");

        }

        public static void calculateAddition_Execute(Program.calculate_Delegate del3)
        {
            Console.WriteLine(del3(2, 3));

        }
              
    }

    
}
