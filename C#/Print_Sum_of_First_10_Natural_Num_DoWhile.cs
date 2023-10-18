using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Sum_of_First_10_Natural_Num_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int sum = 0;

            do
            {
                Console.WriteLine(counter);
                sum = counter + sum;
                counter++;
            }
            while (counter <= 10);
            
            Console.WriteLine("Sum = {0}",sum);
            Console.ReadKey();
        }
    }
}
