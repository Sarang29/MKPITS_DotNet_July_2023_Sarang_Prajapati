using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Triangle_Equi_Isocel_Scale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter Angle A");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Angle B");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Angle C");
            c = Convert.ToInt32(Console.ReadLine());

            if(a==b && b==c && c==a)
            {
                Console.WriteLine("Triangle is Equilateral");
            }
            else if(a==b || b==c )
            {
                Console.WriteLine("Triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle is Scalene");
            }
            Console.ReadKey();
        }
    }
}
