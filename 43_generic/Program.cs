namespace _43_generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic => No particular data type
            // add <T> or <Thing> to classes,methods,fields
            // allow code reusability for different data type

            int[] intArray = { 71, 72, 73 };
            double[] doubleArray = { 1.7, 3.01, 3.7 };
            String[] stringArray = { "Mansoor Ahmed", "Tofique Ahmed", "Tufail Ahmed" };

            displayElement(intArray);
            displayElement(doubleArray);
            displayElement(stringArray);
        }

         static void displayElement<Thing>(Thing[] array)
        {
            foreach(Thing itemArray in array)
            {
                Console.Write(itemArray + " ");

            }
            Console.WriteLine();

        }
    }
}
