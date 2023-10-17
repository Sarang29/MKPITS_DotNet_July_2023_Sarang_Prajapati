using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Table_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter=1;
            int result = 0;

            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());

            while (counter<=10)
            {
                result = num * counter;
                if(counter <=num)
                {
                    Console.WriteLine("{0} * {1} = {2}", num, counter, result);
                    counter++;
                   
                }
               
            }
            Console.ReadKey();
        }
    }
}
