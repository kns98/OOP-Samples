using System;
using System.Collections.Generic;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //create books array
            var books = new List<Book>
            {
                new Book(1, "All about elephants", "Kevin Sheth"),
                new Book(2, "Patajali Cats", "Leah Sheth"),
                new Book(3, "Greeting Card", "Jazmine Sheth"),
                new Book(4, "Lantern", "Odie")
                
            };

            Library mylib = new Library(books);
            mylib.Borrow(
            mylib.FindBookById(1), "Tejas Jog");
            

        }
    }
}
