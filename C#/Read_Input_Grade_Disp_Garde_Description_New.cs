using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Input_Grade_Disp_Garde_Description
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;

            Console.WriteLine("Enter Character");
            op=Convert.ToChar(Console.ReadLine());

            if(op == 'e')
            {
                Console.WriteLine("Excellent");
            }
            else if(op == 'v')
            {
                Console.WriteLine("Very Good");
            }
            else if(op == 'g')
            {
                Console.WriteLine("Good");
            }
            else if(op == 'a')
            {
                Console.WriteLine("Average");
            }
            else if(op == 'f')
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            Console.ReadKey();
        }
    }
}
