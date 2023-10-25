using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Statement_Example_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 15;

            while(true)
            {
                Console.WriteLine(i);
                i--;
                if(i >= 3)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
