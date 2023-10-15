using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseTriangleCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter B");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter C");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("It is a Equilateral Triangle");
            }
            else
            {
                Console.WriteLine("It is not Equilateral Triangle");
            }
            Console.ReadKey();
        }
    }
}