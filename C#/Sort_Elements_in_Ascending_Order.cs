using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Elements_in_Ascending_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
           
            int temp = 0;

            Console.WriteLine("Enter Elements : ");
            for(int i=0; i<5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }
       
            for(int i = 0; i<5;i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Elements in Ascending Order are : ");
            for(int i = 0; i<5;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
