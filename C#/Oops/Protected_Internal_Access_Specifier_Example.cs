using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Internal_Access_Specifier_Example
{
    class Shape
    {
        protected internal string colour;
    }

    class Rectangle : Shape
    {
        protected internal void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    class Circle : Shape
    {
        protected internal void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.colour = "Orange";
            Console.WriteLine("Shape Colour : "+r.colour);
            r.draw();

            Circle c = new Circle();
            c.colour = "red";
            Console.WriteLine("Shape Colour : " + c.colourN);
            c.draw();

            Console.ReadKey();

        }
    }
}
