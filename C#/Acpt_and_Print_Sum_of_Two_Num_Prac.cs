﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_and_Print_Sum_of_Two_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2, sum;
            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("Sum = " + sum);
            Console.ReadKey();
        }
    }
}
