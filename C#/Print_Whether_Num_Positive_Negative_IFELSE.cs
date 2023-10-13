using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Whether_Num_Positive_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine()); 

            if(num > 0)
            {
                Console.WriteLine("It is Positive Number");
            }
            else
            {
                Console.WriteLine("It is Negative Number");
            }
            Console.ReadKey();
        }
    }
}
