using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Class_Person_Get_Set
{
    class Person
    {
        public string name { get; set; }
        public string address { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Sarang";
            p.address = "Nagpur";

            Console.WriteLine("Person Name : " + p.name);
            Console.WriteLine("Person Location : " + p.address);

            Console.ReadKey();
        }
    }
}
