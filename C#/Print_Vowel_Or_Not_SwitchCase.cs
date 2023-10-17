using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Vowel_Or_Not_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;

            Console.WriteLine("Enter Character");
            op=Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("It is Vowel");
                    break;

                default:

                    Console.WriteLine("It is Consonent");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
