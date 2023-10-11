using System;

namespace Square_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, square;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("Square = " + square);
            Console.ReadKey();
        }
    }
}
