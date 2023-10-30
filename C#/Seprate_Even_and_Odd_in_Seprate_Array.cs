using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seprate_Even_and_Odd_in_Seprate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];

            Console.WriteLine("Enter Number : ");
            for(int i = 0; i<5;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int j = 0, k = 0;
            for(int i=0;i<5;i++)
            {
                if (arr[i]%2==0)
                {
                    arr1[j] = arr[i];
                    j++;
                }
                else
                {
                    arr2[k] = arr[i];
                    k++;
                }
            }

            Console.Write("Even Numbers are : ");
            for (int i=0;i<j; i++)
            {
                Console.Write(" "+arr1[i]);
            }

            Console.Write("\nOdd Numbers are : ");
            for (int i=0;i<k;i++)
            {
                Console.Write(" "+arr2[i]);
            }
            Console.ReadKey();
        }
    }
}
