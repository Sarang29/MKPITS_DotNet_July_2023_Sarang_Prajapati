using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Second_Largest_Element_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers of Elements");
            int n = Convert.ToInt32(Console.ReadLine());


            int[] arr = new int[n];

            Console.WriteLine("Enter Elements :");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);

            int ln = arr[arr.Length-2];
            Console.WriteLine("Second Largest Element is : "+ln);
            Console.ReadKey();

        }
    }
}
