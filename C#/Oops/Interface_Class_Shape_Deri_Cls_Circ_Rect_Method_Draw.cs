using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Class_Shape_Deri_Cls_Circ_Rect_Method_Draw
{
    interface Shape
    {
        void draw();
    }
    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();

            s = new Circle();
            s.draw();

            Console.ReadKey();
        }
    }
}
