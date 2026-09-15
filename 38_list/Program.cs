using System.Collections.Generic;

namespace _38_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list => Data structure that represents list of object and can be access
            // by index similar to array but that can dynamically increase/decrease in size
            // using System.Collections.Generic

            List<String> bookList = new List<String>();

            // Add value in list
            bookList.Add("English");
            bookList.Add("Urdu");
            bookList.Add("Mathematics");

            // Remove value in list
            bookList.Remove("Urdu");

            // Add value in particular position
            bookList.Insert(0, "Sindhi");

            // find length of list
            Console.WriteLine($"Length of bookList is {bookList.Count}");

            // Check either value is present or not in list
            Console.WriteLine(bookList.Contains("Sindhi"));
            Console.WriteLine(bookList.Contains("Science"));

            // Check which value is present on which index
            Console.WriteLine($"Index of Sindhi is {bookList.IndexOf("Sindhi")}");

            // bookList.Sort() => Arrange value in alphabetical order
            // bookList.Reverse() => Reverse the value
            // bookList.Clear() => Delete all value of list

            // List to Array

            String[] bookArray = bookList.ToArray();

            bookArray[0] = "Pschology";

            foreach(String book in bookList)
            {
                Console.WriteLine(book);

            }

            foreach(String book in bookArray)
            {
                Console.WriteLine(book);

            }


            List<int> numbers = new List<int>()
            {
                1,2,3,4,5
            };

            for(int i=0; i<numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);

            }

        }
    }
}
