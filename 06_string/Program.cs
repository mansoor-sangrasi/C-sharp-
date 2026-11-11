namespace _06_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn string data type in C-sharp");


            // string is immutable create krna ka baad wo change nhi hoti
            // string method new string return krta hn
            // ToUpper()
            // ToLower()
            // Replace(old,new)
            // Insert(index,value)
            // Substring(start_index,length)
            // Length

            String fullName = "Mansoor Ahmed";
            String upper = fullName.ToUpper();
            String lower = fullName.ToLower();
            Console.WriteLine($"Upper Case:{upper}");
            Console.WriteLine($"Lower Case:{lower}");
            Console.WriteLine($"Length of fullName:{fullName.Length}");

            String phoneNumber = "@92371/1942571";
            phoneNumber = phoneNumber.Replace("@", "+");
            phoneNumber = phoneNumber.Replace("/", "-");
            phoneNumber = phoneNumber.Replace("2", "5");
            phoneNumber = phoneNumber.Replace("9", "10");
            phoneNumber = phoneNumber.Replace("1", "11");
            phoneNumber = phoneNumber.Replace("1", "20");
            phoneNumber = phoneNumber.Replace("1", "200");
            phoneNumber = phoneNumber.Replace("1", "300");
            phoneNumber = phoneNumber.Replace("3", "400");
            phoneNumber = phoneNumber.Replace("4", "7");
            phoneNumber = phoneNumber.Replace("4", "12");




            Console.WriteLine(phoneNumber);

            String userName = fullName.Insert(0, "@");
            userName = userName.Insert(8, "-");
            Console.WriteLine($"UserName:{userName}");

            String firstName = fullName.Substring(0, 7);
            String lastName = fullName.Substring(8, 5);
            Console.WriteLine($"firstName:{firstName}");
            Console.WriteLine($"lastName:{lastName}");
        }
    }
}
