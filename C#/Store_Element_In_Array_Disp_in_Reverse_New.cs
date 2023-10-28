using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Element_In_Array_Disp_in_Reverse_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int i;
            
                
                for (i = 0;i < 5; i++)
                { 
                Console.WriteLine("Enter Number : ");
                num[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Numbers Stored in Array : ");
                for(i = 0; i < 5; i++)
                {
                Console.Write(" "+ num[i]);
                }

                Console.Write("\nArray in Reverse : ");
                 for(i = 5-1;i >= 0; i--)
                 {
                     Console.Write(" "+num[i]);
                 }
            Console.ReadKey();
        }
    }
}
