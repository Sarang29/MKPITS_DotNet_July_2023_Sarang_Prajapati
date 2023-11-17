using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_PolyMorphism_Class_Dog_Inherit_From_Class_Animal
{
    class Animal
    {
        public string color = "White";
    }

    class Dog:Animal
    {
        public string color = "Black";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal d = new Dog();
            Console.WriteLine(d.color);

            Console.ReadKey();
        }
    }
}
