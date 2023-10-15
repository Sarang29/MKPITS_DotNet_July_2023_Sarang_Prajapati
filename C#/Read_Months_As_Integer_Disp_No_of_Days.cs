using System;

namespace IfelseMonthDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Enter Month Num");
            month = Convert.ToInt32(Console.ReadLine());



            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine("In month have a 31 Days");
            }
            else if (month == 2)
            {
                Console.WriteLine("In Month 28 or 29 Days");

            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine("In month have a 30 Days");
            }
            else
            {
                Console.WriteLine("Invalid Month Num");
            }
            Console.ReadKey();

        }
    }
}