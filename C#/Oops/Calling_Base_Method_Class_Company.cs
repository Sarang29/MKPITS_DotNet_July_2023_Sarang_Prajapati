using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Base_Method_Class_Company
{
    class Company
    {
        public string Name = "mkp";

        public void display()
        {
            Console.WriteLine("Company Name : " + Name);
        }
    }

    class Franchise : Company
    {
        public string Name = "Mkpits";

        public void display()
        {
            base.display();
            Console.WriteLine("Company Name : " + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Franchise f = new Franchise();

            f.display();

            Console.ReadKey();
        }
    }
}
