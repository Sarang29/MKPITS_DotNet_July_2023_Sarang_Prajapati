using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Create_Class_Book_and_Create_Array_of_Object
{
    class Book
    {
        string title;
        string author;
        int publication_year;

        public void getdata(string title, string author, int publication_year)
        {
            this.title = title;
            this.author = author;
            this.publication_year = publication_year;
        }

        public void displaydata()
        {
            Console.WriteLine("\nTitle = " + title);
            Console.WriteLine("Author = " + author);
            Console.WriteLine("Publication Year = " + publication_year);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] book1 = new Book[3];
            book1[0] = new Book();
            book1[1] = new Book();
            book1[2] = new Book();

            string title = null;
            string author = null;
            int publication_year = 0;

            for(int i = 0; i < 3;i++)
            {
                Console.Write("\nEnter Title: ");
                title=Console.ReadLine();

                Console.Write("Enter Author: ");
                author=Console.ReadLine();

                Console.Write("Enter Publication Year: ");
                publication_year = Convert.ToInt32(Console.ReadLine());

                book1[i].getdata(title, author, publication_year);
            }

            for(int i=0;i<3;i++)
            {
                book1[i].displaydata();
            }

            Console.ReadKey();
        }
    }
}
