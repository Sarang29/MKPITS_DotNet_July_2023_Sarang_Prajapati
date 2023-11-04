using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Book_Input_From_User_Const_With_Para
{
    class Book
    {
        int Id;
        string Title;
        string Author;
        int Price;

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
            Console.Write("Enter Book Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Title : ");
            string title = Console.ReadLine();

            Console.Write("Enter Book Author : ");
            string author = Console.ReadLine();

            Console.Write("Enter Book Price : ");
            int price = Convert.ToInt32(Console.ReadLine());

            Book book1 = new Book(id,title,author,price);
            book1.display();

            Console.ReadKey();
        }
    }
}
