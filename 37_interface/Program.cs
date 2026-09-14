namespace _37_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // interface => It define contract of all classes inheriting from should follow
           // interface declare what a class should have
           // inheriting class define how it should do it
           // Benefit => security + multiple inheritance + plug and play

            // Difference b/w interface and abstract class
            // interface aik agreement hota hn jo ya btata hn ya method hone chahe hn
            // in interface only method can be declare
            // in abstract class method can be declare as well as implemented

            Samsung samsung = new Samsung();
            Oppo oppo = new Oppo();
            Iphone iphone = new Iphone();

            samsung.Camera();
            oppo.Camera();
            iphone.Camera();
        }

        interface Icamera
        {
            void Camera();
        }

        class Samsung : Icamera
        {
            public void Camera()
            {
                Console.WriteLine("Samsung camera is 10px");
            }

        }

        class Oppo : Icamera
        {
            public void Camera()
            {
                Console.WriteLine("Oppo camera is 8px");
            }

        }

        class Iphone : Icamera
        {
            public void Camera()
            {
                Console.WriteLine("Iphone camera is 100px");
            }

        }
    }
}
