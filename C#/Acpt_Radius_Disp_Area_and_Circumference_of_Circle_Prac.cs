using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Radius_Disp_Area_and_Circumference_of_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, circ;
            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
            Console.WriteLine("Area of Circle = " + area);
            Console.WriteLine("Circumference of Circle = " + circ);
            Console.ReadKey();
        }
    }
}
