using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Display_Hello_and_Sayhi_Method_Example
{
    class Book
    {
        public static void Hello()
        {
            Console.WriteLine("Hello From Hello Method");
        }

        public void sayhi()
        {
            Console.WriteLine("Say Hi From Sayhi Method");
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.Hello();

            Book book1 = new Book();
            book1.sayhi();

            Console.ReadKey();
        }
    }
}
