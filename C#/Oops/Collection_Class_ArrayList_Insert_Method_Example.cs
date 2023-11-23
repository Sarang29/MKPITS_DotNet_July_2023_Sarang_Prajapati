using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Class_ArrayList_Insert_Method_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(10);
            ar.Add(5);
            ar.Add(7);
            ar.Add(6);
            ar.Add(3);

            ar.Insert(4, 17);

            foreach(object ob in ar)
            {
                Console.WriteLine("Numbers : "+ob);
            }

            Console.ReadKey();
        }
    }
}
