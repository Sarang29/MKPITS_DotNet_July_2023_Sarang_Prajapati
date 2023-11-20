using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrsct_Class_Shape_By_Override_Method_Draw
{
    abstract class Shape
    {
        public abstract void draw();
    }

    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Hello From Rectangle Class");
        }
    }

    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Hello From Circle Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape r = new Rectangle();
            r.draw();

            Shape c = new Circle();
            c.draw();

            Console.ReadKey();
        }
    }
}
