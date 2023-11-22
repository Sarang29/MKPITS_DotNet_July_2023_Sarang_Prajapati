using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Two_NameSpace_Class_Accessing_EachOther
{
    namespace First
    {
        class Hello
        {
            public void Sayhello()
            {
                Console.WriteLine("Hello From First NameSpace");
            }
        }
    }

    namespace Second
    {
        class Hello
        {
            public void SayHello()
            {
                Console.WriteLine("Hello From Second NameSpace");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            First.Hello h1 = new First.Hello();
            h1.Sayhello();

            Second.Hello h2 = new Second.Hello();
            h2.SayHello();

            Console.ReadKey();
        }
    }
}
