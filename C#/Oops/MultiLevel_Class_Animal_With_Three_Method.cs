
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Class_Animal_With_Three_Method
{
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    class BabyDog:Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BabyDog d1=new BabyDog();
            d1.eat();
            d1.Bark();
            d1.Weep();

            Console.ReadKey();
        }
    }
}
