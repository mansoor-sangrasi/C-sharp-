namespace _29_overloadedConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructor => Technique to create multiple constructor
            // with different set of parameter.
            // name + parameter = signature

            Pizza pizza1 = new Pizza("stuffed crust", "red souce", "mozzarella", "pepperoni");
            Pizza pizza2 = new Pizza("stuffed crust", "red souce", "mozzarella");
            Pizza pizza3 = new Pizza("stuffed crust", "red souce");
            Pizza pizza4 = new Pizza("stuffed crust");

        }
    }

    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread, String sauce, String cheese, String topping)
        {

        }
        public Pizza(String bread, String sauce, String cheese)
        {

        }
        public Pizza(String bread, String sauce)
        {

        }
        public Pizza(String bread)
        {

        }
    }
}
