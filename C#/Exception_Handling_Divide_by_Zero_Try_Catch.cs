using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Divide_by_Zero_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            int res = 0;

            Console.WriteLine("Enter Number 1");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            n= Convert.ToInt32(Console.ReadLine());
            try
            {
                res = num / n;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Result : " + res);
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
