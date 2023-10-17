using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Month_Num_Disp_Month_Name_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthno;

            Console.WriteLine("Enter Month Number Between 1 and 12");
            monthno=Convert.ToInt32(Console.ReadLine());

            switch (monthno)
            {
                case 1:
                    Console.WriteLine("Janurary");
                    break;

                case 2:
                    Console.WriteLine("Feburary");
                    break;

                case 3:
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("June");
                    break;

                case 7:
                    Console.WriteLine("July");
                    break;

                case 8:
                    Console.WriteLine("August");
                    break;

                case 9:
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine("Octomber");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Invalid Month Number");
                    break;
            }
            Console.ReadKey();
        }
    }
}
