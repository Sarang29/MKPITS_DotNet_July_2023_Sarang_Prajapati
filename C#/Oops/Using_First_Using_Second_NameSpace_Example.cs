using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First;
using Second;

    namespace First
    {
        class Hello
        {
            public void SayHello()
            {
                Console.WriteLine("Hello From First NameSpace");
            }
        }
    }

    namespace Second
    {
        class Welcome
        {
            public void SayWelcome()
            {
                Console.WriteLine("Welcome From Second NameSpace");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello h1 = new Hello();
            h1.SayHello();

            Welcome w1 = new Welcome();
            w1.SayWelcome();

            Console.ReadKey();

        }
    }

