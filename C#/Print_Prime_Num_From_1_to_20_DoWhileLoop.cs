using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Prime_Num_From_1_to_20_DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime No : 2");

            int num = 3;
            int counter = 2;
            int flag = 0;

            do
            {
                counter = 2;
                flag = 0;
                while (num > counter)
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
            } while (num <= 20);
            Console.ReadKey();
        }
    }
}
