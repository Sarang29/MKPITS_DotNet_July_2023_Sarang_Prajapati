using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Class_Number_Disp_Capacity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList number = new ArrayList();
            number.Add(6);
            number.Add(7);
            number.Add(9);
            number.Add(10);
            number.Add(3);

            foreach(object obj in number)
            {
                Console.WriteLine("number : " + obj);
            }
            Console.WriteLine("Capacity : " + number.Capacity);
            Console.WriteLine("Count : " + number.Count);

            Console.ReadKey();
        }
    }
}
