using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_New_Prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 1;
            int cube = 0;

            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());

            while (counter <= num)
            {
                cube = counter * counter * counter;
                Console.WriteLine("Cube = {0}", cube);
                counter++;

            }
            Console.ReadKey();
        }
    }
}
