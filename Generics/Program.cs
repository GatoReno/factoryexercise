using System;
using Generics.models;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Generics!");

            var book = new Book { Name = "x1", Author = "xxyyxx"};
            var book2 = new Book { Name = "2x1", Author = "2xxyyxx" };
            var book3 = new Book { Name = "2x13", Author = "2xxyyxx2" };

            var numbers = new GenericList<int>();
            numbers.Add(11); numbers.Add(21); numbers.Add(31); numbers.Add(41);

            var books = new GenericList<Book>();
            books.Add(book); books.Add(book2); books.Add(book3);

            
            Console.ReadLine();
        }
    }
}
