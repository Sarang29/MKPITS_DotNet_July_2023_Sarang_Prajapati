using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Names_Push_Peek_Pop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Stack : ");
            Stack stack = new Stack();
            stack.Push("Sarang");
            stack.Push("Lucky");
            stack.Push("David");
            stack.Push("Akash");
            stack.Push("Sujit");

            foreach(string og in stack)
            {
                Console.WriteLine("Names : "+og);
            }
            Console.WriteLine();

            stack.Push("Mayur");
            stack.Push("Abhishek");
            stack.Push("Raj");

            Console.WriteLine("Next Poppable Name : " + stack.Peek());
            foreach(string og in stack)
            {
                Console.WriteLine("Names : " + og);
            }
            Console.WriteLine();

            Console.WriteLine("After Pop Method");
            stack.Pop();
            stack.Pop();
            foreach(string og in stack)
            {
                Console.WriteLine("Names : " + og);
            }


            Console.ReadKey();
        }
    }
}
