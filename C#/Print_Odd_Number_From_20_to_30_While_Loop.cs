﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Odd_Number_From_20_to_30_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 20;

            while(counter <= 30)
            {
                if(counter % 2 != 0)
                {
                    Console.WriteLine("{0} is Odd Number", counter);
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}
