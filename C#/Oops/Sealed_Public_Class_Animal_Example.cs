using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Public_Class_Animal_Example
{
    sealed public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class Dog : Animal // Compile Time Error//
    {
        public void bark()
        {
            Console.WriteLine("Barking..");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
