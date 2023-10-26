using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Variable_to_Calculate_Area_Circ
{
    internal class Program
    {
        static void calculate(int radius,ref float area,ref float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 5;
            float area=0, circ=0;
            calculate(radius, ref area, ref circ);
            Console.WriteLine("Area of Circle = " + area);
            Console.WriteLine("Circumference of Circle = " + circ);
            Console.ReadKey();
        }
    }
}
