using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Array_String_Methods
{
    class Product
    {
        public double Price;
        public int Count;
        public DateTime ReleaseDate;

        public Product(double price,int count, DateTime date)
        {
            Price = price;
            Count = count;
            ReleaseDate = date;
        }

        public void baseInfo()
        {
            Console.WriteLine($"Price: {Price}, Count: {Count}, Release date: {ReleaseDate}");
        }

        public void Sell()
        {
            if(Count > 0)
            {
                Count--;
                Console.WriteLine($"Tural kitabi satdi, qaldi: {Count}");
            }
            else
            {
                Console.WriteLine("Tural kitabi satmir");
            }
        }
    }
}
