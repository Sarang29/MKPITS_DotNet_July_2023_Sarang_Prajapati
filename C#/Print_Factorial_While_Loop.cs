using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Factorial_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;

            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());

            while(num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("Factorial = {0}", fact);
            Console.ReadKey();
        }
    }
}
