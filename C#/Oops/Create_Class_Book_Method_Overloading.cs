using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Book_Method_Overloading
{
    class Book
    {
        int Id;
        string Title;
        string Author;
        int Price;

        public void getdata()
        {
            Id = 1;
            Title = "Stars";
            Author = "Lucky";
            Price = 600;
        }

        public void getdata(int Id,string Title, string Author, int Price)
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
            Console.WriteLine("Book Price : " + Price+"\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.getdata();
            book.display();

            Book book1 = new Book();
            book1.getdata(2,"Fault In Our Stars","Chetan Bhagat",800);
            book1.display();

            Console.Write("Enter Book id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Title : ");
            string title = Console.ReadLine();

            Console.Write("Enter Book Author : ");
            string author = Console.ReadLine();

            Console.Write("Enter Book Price : ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Book book3 = new Book();
            book3.getdata(id, title, author, price);
            book3.display();

            Console.ReadKey();
        }
    }
}
