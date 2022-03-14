using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Array_String_Methods
{
    class Newspaper:Product
    {
        public string Advertisement;
        public string Article;

        public Newspaper(string advertisement,string article,double price,int count, DateTime date):base(price,count,date)
        {
            Advertisement = advertisement;
            Article = article;
        }

        public void Info()
        {
            Console.WriteLine($"Advs: {Advertisement}, Article: {Article}");
        }

    }
}
