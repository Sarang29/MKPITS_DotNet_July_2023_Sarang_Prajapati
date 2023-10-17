using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_natural_Number_From_1_to_10_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Counter = 1;

            while(Counter<=10)
            {
                Console.WriteLine(+Counter);
                Counter++;
            }
            Console.ReadKey();
        }
    }
}
