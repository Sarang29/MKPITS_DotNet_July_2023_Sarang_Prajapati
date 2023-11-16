using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_Method_Class_Dog_Deri_From_Class_Animal
{
    class Animal
    {
        public void bark()
        {
            Console.WriteLine("Dog Is Barking");
        }
    }

    class Dog:Animal
    {
        public void eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();

            d1.bark();
            d1.eat();

            Console.ReadKey();
        }
    }
}
