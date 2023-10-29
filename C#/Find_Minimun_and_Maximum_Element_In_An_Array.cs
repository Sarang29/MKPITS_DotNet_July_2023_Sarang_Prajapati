using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Minimun_and_Maximum_Element_In_An_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0, min = 0, i = 0;
            int[] arr = new int[3];
            for(i=0;i<3;i++)
            {
                Console.WriteLine("Enter Number : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[0];
            min = arr[0];
            for(i=0;i<3;i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Max : " + max);
            Console.WriteLine("Min : " + min);
            Console.ReadKey();
        }
    }
}
