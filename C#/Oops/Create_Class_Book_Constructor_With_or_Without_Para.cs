using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Book_Constructor_With_or_Without_Para
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
            Title = "Dotnet";
            Author = "Ashish";
            Price = 9000;
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
            Console.WriteLine();
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
            Book book = new Book();
            book.display();

            Book book1 = new Book(2, "Java", "Lucky", 1000);
            book1.display();

            Console.WriteLine();
            Console.Write("Enter Book Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Title : ");
            string title = Console.ReadLine();

            Console.Write("Book Author : ");
            string author = Console.ReadLine();

            Console.Write("Book Price : ");
            int price = Convert.ToInt32(Console.ReadLine()); 
            
            Book book2 = new Book(id, title, author, price);
            book2.display();

            Console.ReadKey();
        }
    }
}
