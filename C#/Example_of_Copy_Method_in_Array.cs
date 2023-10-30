using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Copy_Method_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 5, 7, 8, 9 };
            int[] arr1 = new int[9];

            Array.Copy(arr, arr1, 9);

            for(int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Copied Elements in Array 2 are : " + arr1[i]);
            }
            Console.ReadKey();
        }
    }
}
