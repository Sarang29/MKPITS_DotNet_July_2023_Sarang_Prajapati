using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 2, num1, num = 0;
            Console.WriteLine("Prime numbers between 1 and 20 : ");
            while (counter < 20)
            {
                int isprime = 1;

                num1 = 2;
                while (num1 <= counter / 2)
                {
                    if (counter % num1 == 0)
                    {
                        isprime = 0;
                        break;
                    }
                    num1++;
                }
                if (isprime == 1)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
            Console.ReadKey();
        }

    }
}