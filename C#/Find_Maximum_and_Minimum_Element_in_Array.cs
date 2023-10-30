using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_and_Minimum_Element_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int max = 0;
            int min = 0;

            Console.WriteLine("Enter 5 Elements : ");
            for(int i =0; i< 5;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = arr[0];
            min = arr[0];
           for(int i =0; i<arr.Length;i++)
            {
                if(arr[i] > max)
                {
                   max = arr[i];
                }

                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum Element = " + max);
            Console.WriteLine("Minimum Element = " + min);
            Console.ReadKey();
        }
    }
}
