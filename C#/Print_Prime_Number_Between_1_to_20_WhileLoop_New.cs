using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Prime_Number_Between_1_to_20_WhileLoop_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime No : 2");

            int num = 3;
            int counter = 2;
            int flag = 0;

            while (num <= 20)
            {
                counter = 2;
                flag = 0;
                while (counter < num)
                {
                    if (num % counter == 0)
                    {
                        flag = 1;
                        break;
                    }
                    counter++;
                }

                if (flag == 0)
                {
                    Console.WriteLine("Prime No : {0}", num);
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
