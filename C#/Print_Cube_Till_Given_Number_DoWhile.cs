using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Cube_Till_Given_Number_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 1;
            int cube;

            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());
            

            do
            {
                cube = counter * counter * counter;
                Console.WriteLine("Cube = {0}", cube);
                counter++;
            }
            while (counter <= num);
            Console.ReadKey();
        }
    }
}
