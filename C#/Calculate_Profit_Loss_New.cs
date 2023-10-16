using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Profit_Loss_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sell, cost, profit;

            Console.WriteLine("Enter Cost Price");
            cost=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Selling Price");
            sell=Convert.ToInt32(Console.ReadLine());

            

            if (cost < sell)
            {
                profit = sell - cost;
                Console.WriteLine("Profit : {0}", profit);
            }
            else if(cost > sell)
            {
                profit = cost - sell;
                Console.WriteLine("Loss = {0}",profit);
            }
            Console.ReadKey();
        }
    }
}
