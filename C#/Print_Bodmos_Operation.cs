using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Bodmos_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = -1 + 4 * 6;
            Console.WriteLine(result);

            result = (35 + 5) % 7;
            Console.WriteLine(result);
            result = 14 + -4 * 6 / 11;
            Console.WriteLine(result);


            result = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
