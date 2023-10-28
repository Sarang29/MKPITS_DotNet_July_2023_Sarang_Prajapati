using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disp_Unique_Element_Of_An_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int counter = 0;
            int i, j;

            for(i=0;i<5;i++)
            {
                arr1[i]=Convert.ToInt32(Console.ReadLine());
            }


            for (i = 0; i < 5; i++)
            {
                counter = 0;
                for (j = 0; j < 5; j++)
                {
                    if (i != j)
                    {
                        if (arr1[i] == arr1[j])
                        {
                            counter++;
                            break;
                        }
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine("Unique Elements Are : " + arr1[i]);
                }
            }
           
            Console.ReadKey();
        }
    }
}
