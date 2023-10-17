using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Grade_Disp_Equivalent_Description_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;

            Console.WriteLine("Enter Grade: E,V,G,A,F");
            op=Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case 'e':
                    Console.WriteLine("Excellent");
                    break;

                case 'v':
                    Console.WriteLine("Very Good");
                    break;

                case 'g':
                    Console.WriteLine("Good");
                    break;

                case 'a':
                    Console.WriteLine("Average");
                    break;

                case 'f':
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
            Console.ReadKey();
            
        }
    }
}
