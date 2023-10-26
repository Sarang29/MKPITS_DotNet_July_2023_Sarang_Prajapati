using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Variable_Calculate_Volume_of_Rect
{
    internal class Program
    {
        static void calculate(int length,int breadth,ref float volume)
        {
            volume = length * breadth;
        }
        static void Main(string[] args)
        {
            int leng = 5;
            int bread = 5;
            float volume = 0;
            calculate(leng, bread, ref volume);
            Console.WriteLine("Volume of Rectangle = " + volume);
            Console.ReadKey();
        }
    }
}
