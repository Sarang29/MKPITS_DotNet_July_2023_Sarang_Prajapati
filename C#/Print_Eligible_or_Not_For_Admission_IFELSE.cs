using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Eligible_or_Not_For_Admission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maths;
            int phy;
            int chem;
            int total;

            Console.WriteLine("Enter Maths Marks");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Physics Marks");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Chemistry Marks");
            chem = Convert.ToInt32(Console.ReadLine());

            total = maths+phy+chem;
            Console.WriteLine("Total Marks = {0}", total);

            if(total >= 180)
            {
                Console.WriteLine("Eligible for Admission");
            }
            else
            {
                Console.WriteLine("Not Eligible For Admission");
            }
            Console.ReadKey();
        }
    }
}
