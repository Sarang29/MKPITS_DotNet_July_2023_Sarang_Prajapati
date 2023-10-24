using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Length_Breadth_Disp_Area_Of_Traiangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, breadth, area;
            Console.WriteLine("Enter Length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            breadth = Convert.ToInt32(Console.ReadLine());
            area = length * breadth;
            Console.WriteLine("Area Of Triangle = " + area);
            Console.ReadKey();
        }
    }
}
