using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wap_Print_1_to_10_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter;

            for (counter=1;counter<=10;counter++)
            {
                Console.WriteLine(counter);
            }
            Console.ReadKey();
        }
    }
}
