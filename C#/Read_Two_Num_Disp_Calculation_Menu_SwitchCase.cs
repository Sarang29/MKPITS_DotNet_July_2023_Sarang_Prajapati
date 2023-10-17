using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Two_Num_Disp_Calculation_Menu_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int choice;
            int result = 0;

            Console.WriteLine("Enter Number 1");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1 For Addition \nEnter 2 For Substraction \nEnter 3 For Multiplication \nEnter 4 For Division");
            choice = Convert.ToInt32(Console.ReadLine());   

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;

                    case 2:
                    result = num1 - num2;
                    break;

                case 3:
                    result = num1 * num2;
                    break;

                case 4:
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.WriteLine("Result = {0}", result);
            Console.ReadKey();
        }
    }
}
