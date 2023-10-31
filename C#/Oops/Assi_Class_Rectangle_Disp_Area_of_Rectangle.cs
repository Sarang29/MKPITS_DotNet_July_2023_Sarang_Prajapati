using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Class_Rectangle_Disp_Area_of_Rectangle
{
    class Rectangle
    {
        int width;
        int height;
        float area;

        public void getdata(int width,int height)
        {
            this.width = width;
            this.height = height;
            area = width * height;
        }

        public void displaydata()
        {
            Console.WriteLine("Width = " + width);
            Console.WriteLine("Height = " + height);
            Console.WriteLine("Area of Rectangle = " + area);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();

            Console.WriteLine("Enter Width & Height");
            int w = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());

            rect1.getdata(w, h);

            rect1.displaydata();

            Console.ReadKey();
        }
    }
}
