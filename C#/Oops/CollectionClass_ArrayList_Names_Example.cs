using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionClass_ArrayList_Names_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Lucky");
            ar.Add("Akash");
            ar.Add("Sujit");
            ar.Add("David");

            foreach(object obj in ar)
            {
                Console.WriteLine("Names : " + obj);
            }
            Console.ReadKey();
        }
    }
}
