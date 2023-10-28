using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disp_Number_Of_Duplicate_Num_In_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            int i;
            int counter = 0;

            for(i=0;i<3;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(i=0;i<3;i++)
            {
                for (int j=i+1;j<3;j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        counter++;
                        break;
                    }
                }    
            }
            Console.WriteLine("Number of Duplicate Elements are : " + counter);
            Console.ReadKey();

        }
    }
}
