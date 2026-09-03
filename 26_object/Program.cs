namespace _26_object
{
     class Program
    {
        static void Main(string[] args)
        {
            // object => Instance of a class.
            // object have fields and method.

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Mansoor Ahmed";
            human1.age = 19;

            human2.name = "Muhammad Siddique";
            human2.age = 52;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();


            
        }
    }

    class Human
    {
        public String name;
        public int age;

        public  void Eat ()
        {
            Console.WriteLine($"{name} is eating");

        }
        public void Sleep ()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }


}
