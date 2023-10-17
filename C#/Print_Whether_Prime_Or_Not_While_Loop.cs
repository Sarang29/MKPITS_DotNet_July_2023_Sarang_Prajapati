using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Whether_Prime_Or_Not_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 2;
            int flag = 0;
            

            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());

            while (counter < num)
            {
                if (num % counter == 0)
                {
                    flag = 1;
                    break;
                
                }
                counter++;
            }
                 if(flag == 0)              
                 {
                    Console.WriteLine("Prime Number");
                 }
                 else
                 {
                    Console.WriteLine("Not a Prime Number");
                 }
           
            Console.ReadKey();
        }
    }
}
