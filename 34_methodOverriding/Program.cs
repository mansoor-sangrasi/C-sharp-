namespace _34_methodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method overriding => provides a new version of method inherited from parent class.
            // method inherited must be abstract,virtual,already overridden.
            // used to ToString(),polymorphism
            // jb hum kohi function inheritance krta hn with a different functionality
            // tb hum method overriding use krta hn or virtual keyword use krta hn.

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal goes to brrr");
        }

    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog goes to woaf");
        }

    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat goes to meow");
        }

    }
}
