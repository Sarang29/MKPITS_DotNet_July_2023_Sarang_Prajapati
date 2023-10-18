using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Sum_of_N_Natural_Num_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 1;
            int sum = 0;

            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(counter);
                sum = sum + counter;
                counter++;
            }
            while (counter <= num);
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadKey();
        }
    }
}
