using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Note: Value Not Exceeding -2,147,483,648 to 2,,147,483,647");
            Console.WriteLine("Enter Number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number = "+a);
            Console.ReadKey();
        }
    }
}
