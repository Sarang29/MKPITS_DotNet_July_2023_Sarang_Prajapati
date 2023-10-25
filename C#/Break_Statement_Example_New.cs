using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Statement_Example_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 1;

            while (counter<=7)
            {
                Console.WriteLine(counter);
                if(counter==num)
                {
                    break;
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}
