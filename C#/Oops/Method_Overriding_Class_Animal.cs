using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding_Class_Animal
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating");
        }
    }

    class Dog:Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Bread");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.eat();

            Console.ReadKey();
        }
    }
}
