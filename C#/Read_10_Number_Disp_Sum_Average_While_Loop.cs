using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_10_Number_Disp_Sum_Average_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10;
            int sum;
            float avg=0;

            Console.WriteLine("Enter Number 1");
            n1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 3");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 4");
            n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 5");
            n5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 6");
            n6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 7");
            n7 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 8");
            n8 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 9");
            n9 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 10");
            n10 = Convert.ToInt32(Console.ReadLine());

            sum=n1+n2+n3+n4+n5+n6+n7+n8+n9+n10;
            Console.WriteLine("Sum = {0}", sum);

            avg = sum / 10.0f;
            Console.WriteLine("Average = {0}", avg);

            Console.ReadKey();
        }
    }
}
