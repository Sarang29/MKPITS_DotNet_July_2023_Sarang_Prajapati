using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Multiplication_of_Two_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, result;

            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            result = num1 * num2 * num3;
            Console.WriteLine("Multiplication = " result;

            Console.ReadKey();
        }
    }
}
