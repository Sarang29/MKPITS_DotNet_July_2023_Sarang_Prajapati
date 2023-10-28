using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Elements_From_one_Array_to_Another
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            int i;

            Console.WriteLine("Enter Number : ");
            for(i=0;i<arr1.Length;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.Write("Elemenys in 1st Array : ");
            for(i=0;i<3;i++)
            {
                Console.Write(" " + arr1[i]);
                arr2[i] = arr1[i];

            }

            Console.Write("\nElemenys in 2nd Array : ");
            for (i=0;i<3;i++)
            {
                if (arr2[i] == arr1[i])
                {
                Console.Write(" "+arr2[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
