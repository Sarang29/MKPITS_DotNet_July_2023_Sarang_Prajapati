using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Three_Sub_Marks_Disp_Tot_Per_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, total;
            float per;
            string grade;

            Console.WriteLine("Enter Subject 1 Marks");
            sub1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Subject 2 Marks");
            sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Subject 3 Marks");
            sub3 = Convert.ToInt32(Console.ReadLine());

            total = sub1+ sub2+sub3;
            Console.WriteLine("Total Marks = {0}", total);

            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("Percentage = {0}", per);

            if(per > 75)
            {
                grade = "Distinct";
            }
            else if (per > 65 && per < 75)
            {
                grade = "First Class";
            }
            else
            {
                grade = "Fail";
            }
            Console.WriteLine("Grade = {0}", grade);
            Console.ReadKey();
        }
    }
}
