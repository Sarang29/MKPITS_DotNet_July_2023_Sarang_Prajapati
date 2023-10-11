using System;

namespace Cube_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cube;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            cube = num * num * num;
            Console.WriteLine("Cube is " + cube);
            Console.ReadKey();
        }
    }
}
