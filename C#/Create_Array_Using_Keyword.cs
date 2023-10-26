using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Array_Using_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            num[0] = 11;
            num[1] = 22;
            num[2] = 33;
            num[3] = 44;
            num[4] = 55;

            Console.WriteLine("Num [0] = " + num[0]);
            Console.WriteLine("Num [1] = " + num[1]);
            Console.WriteLine("Num [2] = " + num[2]);
            Console.WriteLine("Num [3] = " + num[3]);
            Console.WriteLine("Num [4] = " + num[4]);

            Console.ReadKey();
        }
    }
}
