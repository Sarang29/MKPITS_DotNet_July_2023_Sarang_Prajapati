using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Print_Fabonacci_Series_By_Func
{
    internal class Program
    {
        static void series(int num)
        {
            

            int num1 = 0;
            int num2 = 1;
            int add = num1 + num2;

            Console.WriteLine("{0} {1}", num1, num2);
            for (int counter = 3; counter <= num; counter++)
            {
                
                num1 = num2;
                num2 = add;
                Console.WriteLine("{0}", add);
                add = num1 + num2;
            
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            series(number);
            Console.ReadKey();
        }
    }
}
