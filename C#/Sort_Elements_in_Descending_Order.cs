using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Elements_in_Descending_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int[] arr = new int[5];

            Console.WriteLine("Enter Elements : ");
            for(int i=0;i<5;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<arr.Length ;i++)
            {
                for(int j=i+1;j<arr.Length ;j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Elements in Descending Order are ");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
