using System;

namespace IfelseOperChoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice, num, square, l, b, rectangle;
            float r, circle;
            Console.WriteLine("1.Circle\n2.Square\n3.Rectangle");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter Radius");
                r = Convert.ToSingle(Console.ReadLine());

                circle = 3.14f * r * r;
                Console.WriteLine("Circle is " + circle);


            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter Num");
                num = Convert.ToInt32(Console.ReadLine());

                square = num * num;
                Console.WriteLine("Square is " + square);

            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter Length");
                l = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Breadth");
                b = Convert.ToInt32(Console.ReadLine());

                rectangle = l * b;
                Console.WriteLine("Rectangle is " + rectangle);

            }
            else
            {
                Console.WriteLine("Invalid days");
            }
            Console.ReadKey();
        }
    }
}