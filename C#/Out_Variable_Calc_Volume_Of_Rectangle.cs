using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Variable_Calc_Volume_Of_Rectangle
{
    internal class Program
    {
        static void calculate(int length,int breadth,out float volume)
        {
            volume = length * breadth;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Length : ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Breadth : ");
            int breadth = Convert.ToInt32(Console.ReadLine());
            float volume;
            calculate(length, breadth, out volume);
            Console.WriteLine("Volume of Rectangle = " + volume);
            Console.ReadKey();
        }
    }
}
