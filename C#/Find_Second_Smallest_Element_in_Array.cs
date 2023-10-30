using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Second_Smallest_Element_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Elements Number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter Elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }

            Array.Sort(arr);

            int ln = arr[0 + 1];
            Console.WriteLine("Second Smallest Number in Array is = "+ln);  
            Console.ReadKey();
        }
    }
}
