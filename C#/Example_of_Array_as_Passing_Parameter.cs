using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Array_as_Passing_Parameter
{
    internal class Program
    {
        static void array(int[] arr)
        {
            int square = 0;
            for(int i=0;i<arr.Length; i++)
            {
                square = arr[i]*arr[i];
            }
            Console.WriteLine("Square of Element = "+square);
        }
        static void Main(string[] args)
        {
            int[] num = { 5 };
            array(num);

            int[] num1 = { 8 };
            array(num1);

            Console.ReadKey();
        }
    }
}
