using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Book_Parameterized_Constructor
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
            Title = "Shining Stars";
            Author = "Lucky";
            Price = 1000;
        }

        public Book(int Id, string Title, string Author, int Price)
        {
            this.Id = Id;
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
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

            Console.ReadKey();
        }
    }
}
