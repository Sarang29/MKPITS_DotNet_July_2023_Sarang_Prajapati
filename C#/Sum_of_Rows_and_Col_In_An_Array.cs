using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Rows_and_Col_In_An_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a1 = new int[2, 2];
            int counter, counter1;
            Console.WriteLine("Enter Elements of Matrix");

            for(counter=0; counter<2; counter++)
            {
                for(counter1=0;counter1<2;counter1++)
                {
                    a1[counter,counter1] = Convert.ToInt32(Console.ReadLine());
                }
                for(counter=0; counter<2;counter++)
                {
                    int sum = 0;
                    for(counter1=0;counter1<2; counter1++)
                    {
                        sum = sum + a1[counter,counter1];
                    }
                    Console.WriteLine("Sum of Rows = "+sum);
                }

                for (counter = 0; counter < 2; counter++)
                {
                    int sum = 0;
                    for (counter1 = 0; counter1 < 2; counter1++)
                    {
                        sum = sum + a1[counter1, counter];
                    }
                    Console.WriteLine("Sum of Colums = " + sum);
                }
                Console.ReadKey();
            }
        }
    }
}
