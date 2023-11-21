using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Cls_Drawable_Deri_Cls_Rect_Circ_Method_Draw
{
    public interface Drawable
    {
        void draw();
    }

    class Rectangle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle..");
        }
    }

    class Circle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle..");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Drawable d;
            d = new Rectangle();
            d.draw();

            d = new Circle();
            d.draw();

            Console.ReadKey();
        }
    }
}
