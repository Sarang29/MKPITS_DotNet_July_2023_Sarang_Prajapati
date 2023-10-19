using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_5_Sub_Marks_Print_Tot_Per_Grade_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;
            int total = 0;
            float per = 0;
            string grade;

            for (int counter = 1; counter <= 5; counter++)
            {
                Console.Write("Enter Subject Marks : ");
                marks = Convert.ToInt32(Console.ReadLine());

                total = marks + total ;

                per = (total / 500.0f) * 100;

            }
                if (per > 75)
                {
                    grade= "Distinct";
                }
                else if (per > 60 && per > 75)
                {
                    grade = "First";
                }
                else
                {
                    grade = "Fail";  
                }
            
                Console.WriteLine("Total = {0}", total);

                Console.WriteLine("Percentage = {0}", per);

                Console.WriteLine("Grade = {0}", grade);

                Console.ReadKey();
            
        }
    }
}
