using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Variable_Example_New
{
    internal class Program
    {
        static void display(ref char ch)
        {
            ch = 'p';
            Console.WriteLine("Character From Method = " + ch);
        }
        static void Main(string[] args)
        {
            char ch = 'a';
            display(ref ch);
            Console.WriteLine("Character From Main = " + ch);
            Console.ReadKey();
        }
    }
}
