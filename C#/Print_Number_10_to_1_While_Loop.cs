using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Number_10_to_1_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;
            while (counter > 0)
            {
                Console.WriteLine(counter);
                counter--;
            }
            Console.ReadKey();
        }
    }
}
