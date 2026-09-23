namespace _46_funcDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // func delegate is used for return type method
            // this delegate take zero or more parameter and last parameter is
            // consider out parameter means return type of method

            Func<String,int,String> func_message = message;
            Console.WriteLine(func_message("Mansoor Ahmed",71));
        }

        public static String message(String msg, int rollNo)
        {
            return "Hello " + msg  + rollNo;
        }
    }

   
}
