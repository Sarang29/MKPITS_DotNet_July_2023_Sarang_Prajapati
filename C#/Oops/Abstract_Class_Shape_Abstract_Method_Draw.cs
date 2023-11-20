using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Shape_Abstract_Method_Draw
{
    abstract class Shape
    {
        public abstract void draw();
    }

    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle....");
        }
    }

    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle.....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Circle();
            s.draw();

            s = new Rectangle();
            s.draw();

            Console.ReadKey();
        }
    }
}
