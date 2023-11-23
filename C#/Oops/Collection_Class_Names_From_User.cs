using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Class_Names_From_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Names : ");
            string names = Console.ReadLine();

            ArrayList ar = new ArrayList();
            ar.Add(names);

            foreach(object  obj in ar)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
