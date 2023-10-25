using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Function_Example_New
{
    internal class Program
    {
        static void addition()
        {
            Console.Write("Enter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            res = num1 + num2;

            Console.WriteLine("Addition : {0}",res+"\n");
        }

        static void substraction()
        {
            Console.Write("Enter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            res = num1 - num2;

            Console.WriteLine("Substraction : {0}", res);
        }
        static void Main(string[] args)
        {
            addition();
            substraction();
            Console.ReadKey();
        }
    }
}
