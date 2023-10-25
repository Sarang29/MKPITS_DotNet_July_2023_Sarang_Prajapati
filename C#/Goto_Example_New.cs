using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Example_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0)
            
                goto yes;
            
            Console.WriteLine("Not a Leap Year");
            goto end;

        yes:
            Console.WriteLine("It is Leap Year");

        end:
            Console.WriteLine("Bye");

            Console.ReadKey();
        }
    }
}
