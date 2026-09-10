namespace _33_objectAsArgument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile1 = new Mobile("Iphone", 12);
            Mobile mobile2 = copyOfObject(mobile1);

            // object pass as argument.
            changeVersion(mobile1, 17);

            Console.WriteLine($"{mobile1.mobile} having version is {mobile1.version}");

            Console.WriteLine($"Copy of mobile1 is {mobile2.mobile} having version is {mobile2.version}");
            
        }

        static void changeVersion(Mobile mobile1,int version)
        {
            mobile1.version = version;

        }

        // object pass as argument and function return copy of object in new one.

        public static Mobile copyOfObject(Mobile mobile1)
        {
            return new Mobile(mobile1.mobile, mobile1.version);
        }

    }

    class Mobile
    {
        public String mobile;
        public int version;

        public Mobile(String mobile, int version)
        {
            this.mobile = mobile;
            this.version = version;

        }
    }
}
