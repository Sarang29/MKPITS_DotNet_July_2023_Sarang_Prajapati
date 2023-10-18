using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Number_1_to_5_doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter <= 5);
            Console.ReadKey();
        
            
        }
    }
}
