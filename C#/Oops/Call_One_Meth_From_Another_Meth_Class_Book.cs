using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_One_Meth_From_Another_Meth_Class_Book
{
    class Book
    {
        int No;
        string Title;
        string Author;
        int Price;

        public void getdata(int No)
        {
            this.No = No;

            getdata(No, "Journey");
        }

        public void getdata(int No, string Title)
        {
            this.No = No;
            this.Title = Title;

            getdata(No, Title, "Lucky");
        }

        public void getdata(int No, string Title,string Author)
        {
            this.No = No;
            this.Title = Title;
            this.Author = Author;

            getdata(No, Title, Author, 500);
        }

        public void getdata(int No, string Title,string Author,int Price)
        {
            this.No = No;
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
        }

        public void display()
        {
            Console.WriteLine("Book Id : " + No);
            Console.WriteLine("Book Title : " + Title);
            Console.WriteLine("Book Author : " + Author);
            Console.WriteLine("Book Price : " + Price+"\n");
        }
            
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();

            book1.getdata(1);
            book1.display();

            Book book2 = new Book();
            book2.getdata(2, "Hell");
            book2.display();

            Book book3 = new Book();
            book3.getdata(3, "Fault", "Chetan");
            book3.display();

            Book book4 = new Book();
            book4.getdata(4, "Heaven", "Ayush", 800);
            book4.display();

            Console.ReadKey();
        }
    }
}
