using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Access_Modifier_Example
{
    public class Person
    {
        public string name;
        public int age;
        public long pno;
        public string email;

        public void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Mobile Number : " + pno);
            Console.WriteLine("Email : " + email);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Sarang";
            p.age = 22;
            p.pno = 7378875024;
            p.email = "Sarangprajapati81@gmail.com";

            p.display();

            Console.ReadKey();
        }
    }
}
