using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism_Class_Circle_Rect_Inherit_From_Class_Shape
{
    class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing....");
        }
    }

    class Circle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    class Rectangle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Shape();
            s.draw();

            s=new Rectangle();
            s.draw();

            s=new Circle();
            s.draw();

            Console.ReadKey();
        }
    }
}
