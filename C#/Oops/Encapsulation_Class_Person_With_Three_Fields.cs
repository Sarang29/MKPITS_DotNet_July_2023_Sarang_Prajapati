using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Class_Person_With_Three_Fields
{
    class Person
    {
        public string name { get; set; }
        public long phoneno { get; set; }
        public string email { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Sarang Prajapati";
            p.phoneno = 7378875024;
            p.email = "Sarangprajapati81@gmail.com";

            Console.WriteLine("Name : "+p.name);
            Console.WriteLine("Mobile Number : " + p.phoneno);
            Console.WriteLine("Email : " + p.email);

            Console.ReadKey();
        }
    }
}
