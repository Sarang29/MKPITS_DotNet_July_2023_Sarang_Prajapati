using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Month_Number_Disp_No_Of_Days_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthno;

            Console.WriteLine("Enter Month Number Between 1 and 12");
            monthno = Convert.ToInt32(Console.ReadLine());

            switch (monthno)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 Days");
                    break;

                case 2:
                    Console.WriteLine("28 Days");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 Days");
                    break;

                default:
                    Console.WriteLine("Invalid Month Number");
                    break;
            }
            Console.ReadKey();
        }
    }
}
