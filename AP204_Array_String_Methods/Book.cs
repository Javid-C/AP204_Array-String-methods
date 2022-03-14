using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Array_String_Methods
{
    class Book:Product
    {
        public string Author;
        public string Genre;

        public Book(string author, string genre,double price, int count,DateTime date):base(price,count,date)
        {
            Author = author;
            Genre = genre;
        }


        public void Info()
        {
            Console.WriteLine($"Author: {Author}, Genre: {Genre}");
        }
    }
}
