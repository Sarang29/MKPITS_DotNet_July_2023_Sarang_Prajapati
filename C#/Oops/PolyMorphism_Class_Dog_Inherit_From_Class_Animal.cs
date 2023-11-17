using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism_Class_Dog_Inherit_From_Class_Animal
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating.....");
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
            Animal a1 = new Dog();
            a1.eat();

            Console.ReadKey();
        }
    }
}
