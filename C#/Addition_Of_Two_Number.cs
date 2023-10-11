using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Of_Two_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, add;
            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            Console.WriteLine("Addition of Two Number = " + add);
            Console.ReadKey();
        }
    }
}
