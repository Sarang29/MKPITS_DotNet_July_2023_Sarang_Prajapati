using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Book_Constructor_Without_Parameter
{
    class Book
    {
        public int bookid {  get; set; }
        public string Title {  get; set; }
        public string Author {  get; set; } 
        public int price {  get; set; }
        public Book()
        {
            bookid = 1;
            Title = "Fault in Our Stars";
            Author = "Chetan Bhagat";
            price = 500;
        }

        public void display()
        {
            Console.WriteLine("Book Id = " + bookid);
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Author : " + Author);
            Console.WriteLine("Price : " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            
            book.display();

            Console.ReadKey();
        }
    }
}
