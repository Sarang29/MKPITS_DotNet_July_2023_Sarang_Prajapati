using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_IndexOutOfRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 78;
            arr[1] = 45;
            arr[2] = 12;

            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Elements : "+arr[i]);
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Byee");
            Console.ReadKey();
        }
    }
}
