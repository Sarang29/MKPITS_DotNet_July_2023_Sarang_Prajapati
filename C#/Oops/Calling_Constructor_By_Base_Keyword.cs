using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Constructor_By_Base_Keyword
{
    class Company
    {
        public string Name = "Mkcl";

        public Company()
        {
            Console.WriteLine("Constructor From Base Class");
            Console.WriteLine("Name : " + Name);
        }
    }

    class Franchise : Company
    {
        public string Name = "Mkpits";

        public Franchise()
        {
            Console.WriteLine("Constructor From Derived Class");
            Console.WriteLine("Name : " + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Franchise f = new Franchise();

            Console.ReadKey();
        }
    }
}
