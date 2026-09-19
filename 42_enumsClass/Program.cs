namespace _42_enumsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enum class => A special class contain set of constant integer value
            // and each integer value have meaningful name
            // to get the integer value from an item you must convert explicitly
            // to an int

            Console.WriteLine($"{Planetgravity.Earth} gravity is {(int)Planetgravity.Earth}");
        }
    }

    enum Planetgravity
    {
        Mercury = 4,
        Venus = 9,
        Earth =  10,
        Mars = 4,
        Jupiter = 25,
        Saturn = 10,
        Uranus = 9,
        Neptune = 11

    
    
    }

}
