namespace _16_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array => A variable that can store multiple values fixed size

            String[] cars = { "HVR", "Civic", "Corolla" };
            for (int i=0; i<cars.Length; i++)
            {
                Console.WriteLine($"Array of car {i} index : {cars[i]}");

            }

            String[] college = new string[3];
            college[0] = "Govt Degree College HYD";
            college[1] = "Govt Degree College MPK";
            college[2] = "Govt Degree College UK";
            for (int i=0; i<college.Length; i++)
            {
                Console.WriteLine($"Array of college {i} index : {college[i]}");

            }
        }
    }
}
