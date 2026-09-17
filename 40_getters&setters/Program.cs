namespace _40_getters_setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // getters and setters => add security to field by encapsulation
            // getters and setters found within properties
            // properties => Combine both fields and methods share same name of field
            // in capital form
            // getter accessor => used to return new value
            // setter accessor => used to assign new value
            // value means argument

            Car car1 = new Car(350);

            car1.Speed = 1000000;

            Console.WriteLine(car1.Speed);

            Student student1 = new Student(110);

            Console.WriteLine(student1.Age);
           
        }
    }

    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;

        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if(value > 400)
                {
                    speed = 400;

                }
                else
                {
                    speed = value;

                }
                
            }
        }
    }

    class Student
    {
        private int age;

        public Student(int age)
        {
            Age = age;

        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if(value>0 && value<120)
                {
                    age = value;

                }
                else
                {
                    Console.WriteLine("Not valid range");
                }
                
            }
        }
    }
}
