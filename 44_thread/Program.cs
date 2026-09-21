namespace _44_thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thread => An execution path of a program
            // we can use multiple thread to perform different task of a program at the same time
            // current thread running is "Main thread"
            // using System.Threading

            Thread t1 = new Thread(printHello);
            Thread t2 = new Thread(printName);

            t1.Start();
            t2.Start();
            

            

        }
        static void printHello()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello");
                Thread.Sleep(1000);
            }
        }

        static void printName()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Mansoor Ahmed");
                Thread.Sleep(1000);
            }
        }
    }
}
