using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Calculate_Meth_Addition_Method_OverLoading
{
    class Calculate
    {
        public void Addition(int num1,int num2)
        {
            int res = num1 + num2;
            Console.WriteLine("Addition of Two Int Para = " + res);
        }

        public void Addition(float n1,float n2)
        {
            float res = n1 + n2;
            Console.WriteLine("Addition of Two FLoat Para = " + res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            Console.WriteLine("Additon of Two Int Para : ");
            calculate.Addition(3, 4);

            Console.WriteLine("Addition of two float :  ");

                calculate.Addition(3.4f, 1.4f);

            Console.ReadKey();
        }
    }
}
