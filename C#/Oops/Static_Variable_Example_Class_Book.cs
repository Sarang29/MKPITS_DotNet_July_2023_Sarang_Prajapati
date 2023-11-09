using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Variable_Example_Class_Book
{
    internal class Program
    {
        class Book
        {
            public static int id;
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            Book.id = 132;
            Console.WriteLine("Book Id : " + Book.id);

            Console.ReadKey();
        }
    }
}
