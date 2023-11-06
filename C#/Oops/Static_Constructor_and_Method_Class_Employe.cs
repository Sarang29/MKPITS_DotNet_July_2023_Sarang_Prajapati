using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor_and_Method_Class_Employe
{
    class Employe
    {
        static string name;
        static int no;

        static Employe()
        {
            Console.WriteLine("Static Constructor Called");
            name = "Sarang";
            no = 1;
        }

        public static void display()
        {
            Console.WriteLine("Employe Number : " + no);
            Console.WriteLine("Employe Name : " + name);
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
