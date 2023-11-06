using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor_Class_Employe
{
    class Employe
    {
        static string Name;

        static Employe()
        {
            Console.WriteLine("Static Constructor Called");
            Name = "Sarang";
        }

        public static void display()
        {
            Console.WriteLine("Employe Name : " + Name);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe.display();
            Console.ReadKey();
        }
    }
}
