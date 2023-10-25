using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Acpt_Two_Num_Disp_Sum_By_Func
{
    internal class Program
    {
        static void sum(int n1,int n2)
        {
            int sum = n1 + n2;
            Console.WriteLine("Sum : {0}",sum);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            sum(num1, num2);
            Console.ReadKey();
        }
    }
}
