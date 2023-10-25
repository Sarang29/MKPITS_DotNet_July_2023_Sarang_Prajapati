using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Two_Num_One_Operator_Func_With_Three_Para
{
    internal class Program
    {
        static int calculate(int num1,int num2,char op)
        {
            int res = 0;
            if(op == '+')
            {
                res = num1 + num2;
            }
            else if(op == '-')
            {
                res = num1 - num2;
            }
            else if(op == '*')
            {
                res = num1 * num2;
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            return res;
               
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1 : ");
            int number1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Operator : ");
            char oper = Convert.ToChar(Console.ReadLine());

            int result = calculate(number1, number2, oper);
            Console.WriteLine("Result = {0}", result);

            Console.ReadKey();
        }
    }
}
