namespace _41_autoImplementedProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // auto-implemented-property =>Shortcut when no logic is required in the property
            // you do not define field for property
            // you only write get or set inside the property

            Student student1 = new Student("Mansoor Ahmed");

            Console.WriteLine(student1.Name);
        }
    }

    class Student
    {
        public String Name { get; set; }

        public Student(String name)
        {
            this.Name = name;

        }

    }
}
