using System;


namespace IfelseCheckOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, total, choice;
            Console.WriteLine("Enter Num1");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num2");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition\n2.Substract\n3.Multiply\n4.Divide\n5.Exit");
            choice = Convert.ToInt32(Console.ReadLine());



            if (choice == 1)
            {
                total = n1 + n2;
                Console.WriteLine("Addition is " + total);
            }
            else if (choice == 2)
            {
                total = n1 - n2;
                Console.WriteLine("Substraction is " + total);
            }
            else if (choice == 3)
            {
                total = n1 * n2;
                Console.WriteLine("Multiplication is " + total);
            }
            else if (choice == 4)
            {
                total = n1 / n2;
                Console.WriteLine("Divide  is " + total);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exit");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }




            Console.ReadKey();




        }
    }
}