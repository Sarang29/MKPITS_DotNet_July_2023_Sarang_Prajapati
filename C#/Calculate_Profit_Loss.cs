using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseProfit_loss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sp, cp, profit;
            Console.WriteLine("Enter cost price");
            cp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter selling price");
            sp = Convert.ToInt32(Console.ReadLine());


            if (cp < sp)
            {
                profit = sp - cp;

                Console.WriteLine("Profit amount is " + profit);
            }
            else if (cp > sp)
            {
                profit = cp - sp;

                Console.WriteLine("Loss amount is " + profit);
            }
            Console.ReadKey();



        }
    }
}