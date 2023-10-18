using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_First_10_Natural_Number_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                Console.WriteLine(counter);
                counter++ ;
            }
            while(counter <= 10);
            Console.ReadKey();
        }
    }
}
