using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Table_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 1;

            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("{0} * {1} = {2}", num, counter, (num * counter));
                counter++;
            }
            while (counter <= 10);
            Console.ReadKey();
        }
    }
}
