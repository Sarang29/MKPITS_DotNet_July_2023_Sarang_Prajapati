using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Sum_Of_First_10_Natural_Number_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter=1;
            int sum = 0;

            while (counter <= 10)
            {
                Console.WriteLine(counter);
                sum = sum + counter;
                counter++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
