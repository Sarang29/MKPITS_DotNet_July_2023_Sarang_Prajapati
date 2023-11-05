using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Book_With_Two_Constructor
{
    class Book
    {
        int Id;
        string Title;
        string Author;
        int Price;

        public Book()
        {
            Id = 1;
            Title = "UnTold Story";
            Author = "David";
            Price = 800;
        }

        public Book(int id, string title, string author, int price)
        {
            Id = id;
            Title = title;
            Author = author;
            Price = price;
        }

        public void display()
        {
            Console.WriteLine("Book Id : " + Id);
            Console.WriteLine("Book Title : " + Title);
            Console.WriteLine("Book Author : " + Author);
            Console.WriteLine("Book Price : " + Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();

            book1.display();

            Book book2 = new Book(2,"Fault In Our Stars","Lucky",900);
            book2.display();

            Console.ReadKey();

        }
    }
}
