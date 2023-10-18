using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Table_Of_Two_Given_Integer_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s=3, e=4;
            int res1, res2;
            int counter=1;

            while(counter <= 10)
            {
                res1 = s * counter;
                res2 = e * counter;

                Console.Write("{0} * {1} = {2}",s,counter,res1);
                Console.Write("\t");
                Console.Write("{0} * {1} = {2}", e, counter,res2);
                counter++;
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
