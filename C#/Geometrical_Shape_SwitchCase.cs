using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrical_Shape_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,r,l,b;
            int s = 0;
            float area;
            int result;

            Console.WriteLine("Enter 1 For Calculating Area of Circle \nEnter 2 For Calculating Area of Rectangle \nEnter 3 For Calculating Area of Square");
            num=Convert.ToInt32(Console.ReadLine());
            
            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter Radius");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14f * r * r;
                    Console.WriteLine("Area Of Circle = {0}", area);
                    break;

                case 2:
                    Console.WriteLine("Enter length");
                    l = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Breadth");
                    b = Convert.ToInt32(Console.ReadLine());
                    area = l * b;
                    Console.WriteLine("Area Of Rectangle = {0}", area);
                    break;

                case 3:
                    Console.WriteLine("Enter Side");
                    s= Convert.ToInt32(Console.ReadLine()); 
                    area = s * s;
                    Console.WriteLine("Area Of Square = {0}", area);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadKey();
        }
    }
}
