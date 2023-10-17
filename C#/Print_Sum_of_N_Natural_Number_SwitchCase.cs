using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Sum_of_N_Natural_Number_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter=1;
            int sum = 0;

            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());

            while(counter<=num)
            {
                Console.Write(counter);
                sum = sum + counter;
                counter++;
               
            }
           
            Console.WriteLine("\nSum = {0}",sum);
            Console.ReadKey();
        }
    }
}
