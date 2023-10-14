using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Temp_Disp_Hot_Cold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;

            Console.WriteLine("Enter Temperature in Centigrade");
            temp=Convert.ToInt32(Console.ReadLine());

            if(temp < 0)
            {
                Console.WriteLine("Wheather is Freezing");
            }
            else if (temp >= 0 && temp <= 10)
            {
                Console.WriteLine("Wheather is Very Cold");
            }
            else if (temp <= 20 && temp > 10)
            {
                Console.WriteLine("Wheather is Cold");
            }
            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("Wheather is Normal");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("Wheather is Hot");
            }
            else if (temp >= 40)
            {
                Console.WriteLine("Wheather is Very Hot");
            }
            Console.ReadKey();
        }
    }
}
