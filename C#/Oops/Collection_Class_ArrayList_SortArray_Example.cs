using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Class_ArrayList_SortArray_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList number = new ArrayList();
            number.Add(3);
            number.Add(4);
            number.Add(7);
            number.Add(1);
            number.Add(5);

            number.Sort();

            Console.WriteLine("Sorted Number");
            foreach(object obj in number)
            {
                Console.WriteLine("Numbers : "+obj);
            }

            Console.ReadKey();
        }
    }
}
