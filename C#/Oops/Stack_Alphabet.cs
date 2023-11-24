using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Stack : ");
            Stack stack = new Stack();
            stack.Push('W');
            stack.Push('A');
            stack.Push('S');
            stack.Push('P');

            foreach(char c in stack)
            {
                Console.WriteLine(c+" ");
            }
            Console.WriteLine();

            stack.Push('D');
            stack.Push('Q');
            stack.Push('U');
            Console.WriteLine("The Next Poppable Char : {0}",stack.Peek());

            foreach(char c in stack)
            {
                Console.WriteLine(c+" ");
            }

            Console.ReadKey();

        }
    }
}
