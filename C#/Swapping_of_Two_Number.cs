using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_of_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Enter Number 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            b = Convert.ToInt32(Console.ReadLine());

            a = a - b;
            b = a + b;
            a = b - a;
            Console.WriteLine("After Swapping");
            Console.WriteLine("Number 1");
            Console.WriteLine(a);
            Console.WriteLine("Number 2");
            Console.WriteLine(b);

            Console.ReadKey();
            

        }
    }
}
