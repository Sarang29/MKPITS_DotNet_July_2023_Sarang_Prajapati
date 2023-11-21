using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Keyword_Example_Class_Animal
{
    class Animal
    {
        public string colour = "White";
    }
    class Dog : Animal
    {
        public string colour = "Black";

        public void displaycolour()
        {
            Console.WriteLine("Dog Colour : " + colour);
            Console.WriteLine("Animal Colour : " + base.colour);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();

            d.displaycolour();

            Console.ReadKey();
        }
    }
}
