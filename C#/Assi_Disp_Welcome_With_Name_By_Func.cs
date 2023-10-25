using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Disp_Welcome_With_Name_By_Func
{
    internal class Program
    {
        static void display()
        {
            Console.Write("Enter Name : ");
            string name=Console.ReadLine();

            Console.WriteLine("Welcome Friend {0}!",name);
            Console.WriteLine("Have a Nice Day!");
        }
        static void Main(string[] args)
        {
            display();
            Console.ReadKey();
        }
    }
}
