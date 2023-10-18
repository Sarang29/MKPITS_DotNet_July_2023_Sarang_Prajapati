using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Table_Vertically_Till_User_Input_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int counter1 = 1;
            int flag;

            Console.WriteLine("Enter Number");
            flag=Convert.ToInt32(Console.ReadLine());

            do
            {
                counter1 = 1;
                while (counter1 <= flag)
                {
                    Console.Write("{0} * {1} = {2}", counter1, counter, (counter * counter1));
                    Console.Write("\t");
                    counter1++;
                }
                counter++;
                Console.WriteLine();
            }while (counter <= 10);
            Console.ReadKey();
        }
    }
}
