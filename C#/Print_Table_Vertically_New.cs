using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Table_Vertically_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("Enter Number");
            flag=Convert.ToInt32(Console.ReadLine());

            int counter = 1;
            int counter1 = 1;

            while (counter <= 10)
            {
                counter1 = 1;
                while (counter1 <= flag)
                {
                    Console.Write("{0} * {1} = {2}", counter1, counter, (counter * counter1));
                    Console.Write("\t");
                    counter1++;
                }
                counter++;
                Console.WriteLine("");

            }
            Console.ReadKey();



        }
    }
}
