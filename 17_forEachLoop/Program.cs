namespace _17_forEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* foreach loop => A simpler way to iterate over an array but it's
            less flexible */

            String[] people = { "Mansoor Ahmed", "Majid Junejo", "Tufail Ahmed" };
            foreach (String person in people)
            {
                Console.WriteLine(person);

            }
        }
    }
}
