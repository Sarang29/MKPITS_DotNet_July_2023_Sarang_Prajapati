using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store_Ten_Elements_in_Array_Disp_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int i;

            Console.WriteLine("Enter 10 Number : ");
            for (i = 0; i < 10; i++)
            {

                num[i] = Convert.ToInt32(Console.ReadLine());
            }
                Console.Write("Elements in Array are : "); 
                for (i = 0; i < 10; i++)
                {
                    Console.Write(" "+ num[i]);
                }
            Console.ReadKey();
        }
        
    }
}
