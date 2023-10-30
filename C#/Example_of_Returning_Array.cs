using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Returning_Array
{
    internal class Program
    {
        static int[] array()
        {
            int[] array1 = { 1, 3, 5, 9, 7 };
            return array1;
        }
        static void Main(string[] args)
        {
            int[] result = array();

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Elements in Array Are : "+result[i]);
            }
            Console.ReadKey();

        }
    }
}
