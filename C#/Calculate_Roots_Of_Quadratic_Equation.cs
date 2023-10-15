using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseRootQuadratic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, total;
            Console.Write("Enter a :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter c :");
            c = Convert.ToInt32(Console.ReadLine());

            total = b * b - 4 * a * c;

            Console.WriteLine(total);
            Console.ReadKey();

        }
    }
}