using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Three_Element_In_Array_Disp_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int i;
            int sum = 0;

            Console.WriteLine("Enter 3 Numbers ");
            for(i=0;i<num.Length;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<num.Length;i++)
            {
                sum = sum + num[i];
            }

            Console.WriteLine("Sum of Three Element = {0}", sum);

            Console.ReadKey();
        }
    }
}
