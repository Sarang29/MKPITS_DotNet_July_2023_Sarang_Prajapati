using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Book_Copy_Constructor
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
            Title = "Journey";
            Author = "Johny";
            Price = 50;
        }

        public Book(Book b2)
        {
            Id=b2.Id;
            Title=b2.Title;
            Author=b2.Author;
            Price=b2.Price;
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

            Book book2 = new Book(book1);
            book2.display();

            Console.ReadKey();
        }
    }
}
