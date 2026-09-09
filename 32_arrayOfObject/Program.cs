using System.ComponentModel.DataAnnotations;

namespace _32_arrayOfObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("English");
            Book book2 = new Book("Mathematics");
            Book book3 = new Book("Urdu");

           // Array of object

             Book[] bookStore = new Book[3];

            // short form of array of object
            // Book[] bookStore = { new Book("English"), new Book("athematics"), new Book("Urdu") };


            bookStore[0] = book1;
            bookStore[1] = book2;
            bookStore[2] = book3;

            Console.WriteLine(bookStore[0].bookName);
            Console.WriteLine(bookStore[1].bookName);
            Console.WriteLine(bookStore[2].bookName);

            foreach (Book book in bookStore)
            {
                Console.WriteLine(book.bookName);

            }


            
        }
    }

    class Book
    {
        public String bookName;

        public Book(String bookName)
        {
            this.bookName = bookName;

        }
    }
}
