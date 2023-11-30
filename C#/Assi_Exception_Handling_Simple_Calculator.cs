using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Exception_Handling_Simple_Calculator
{
    class Calculator
    {
        public double number1;
        public double number2;

        public Calculator(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public void Addition(double number1, double number2)
        {
            double result = number1 + number2;
            Console.WriteLine("Addition : "+result);
        }

        public void Substraction(double number1, double number2)
        {
            double result = number1 - number2;
            Console.WriteLine("Substraction : "+result);
        }

        public void Multiplication(double number1, double number2)
        {
            double result = number1 * number2;
            Console.WriteLine("Multiplication : "+result);
        }

        public void Division(double number1, double number2)
        {
            double result = number1 / number2;
            Console.WriteLine("Division : "+result);
        }
        public void clear()
        {
            double result = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers");
            double n1 = Convert.ToInt32(Console.ReadLine());
            double n2 = Convert.ToInt32(Console.ReadLine());

            Calculator c = new Calculator(n1,n2);

            Console.WriteLine("Enter Addition,Substraction,Division,Multiplication");
            string choice = Console.ReadLine();

            if(choice == "Addition")
            {
                c.Addition(n1, n2);
            }
            else if(choice == "Substraction")
            {
                c.Substraction(n1, n2);
            }
            else if(choice == "Multiplication")
            {
                c.Multiplication(n1, n2);
            }
            else if(choice == "Division")
            {
                c.Division(n1, n2);
            }
            else
            {
                Console.WriteLine("You Choose Invalid operator");
            }

            c.clear();
            Console.ReadKey();
        }
    }
}
