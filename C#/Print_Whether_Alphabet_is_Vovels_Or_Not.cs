using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Whether_Alphabet_is_Vovels_Or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char p;

            Console.WriteLine("Enter Alphabet");
            p=Convert.ToChar(Console.ReadLine());

            if(p == 'a')
            {
                Console.WriteLine("It is Vovel");
            }
            else if (p == 'e')
            {
                Console.WriteLine("It is Vovel");
            }
            else if (p == 'i')
            {
                Console.WriteLine("It is Vovel");
            }
            else if (p == 'o')
            {
                Console.WriteLine("It is Vovel");
            }
            else if (p == 'u')
            {
                Console.WriteLine("It is Vovel");
            }
            else
            {
                Console.WriteLine("It is consonant");
            }
            Console.ReadKey();
        }
    }
}
