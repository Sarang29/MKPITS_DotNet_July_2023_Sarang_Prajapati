using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseGradeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grade;
            Console.WriteLine("Enter A");
            grade = Console.ReadLine();

            if (grade == "a")
            {
                Console.WriteLine("Average");
            }
            else if (grade == "e")
            {
                Console.WriteLine("Excellent");
            }
            else if (grade == "v")
            {
                Console.WriteLine("Very Good");
            }
            else if (grade == "g")
            {
                Console.WriteLine("Good");
            }
            else if (grade == "f")
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }
    }
}