using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_square_of_Num_With_Repeating_Choice_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, square;
            char choice;


            do
            {
                Console.WriteLine("Enter Number");
                num = Convert.ToInt32(Console.ReadLine());

                square = num * num;
                Console.WriteLine("Square = {0}", square);

                Console.WriteLine("Do You Want To Contine Press y Otherwise Press Any Key ");
                choice = Convert.ToChar(Console.ReadLine());

            }
            while (choice == 'y' || choice == 'Y');
            Console.ReadKey();
            }
        }
    }

