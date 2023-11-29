using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Ex_Exception_Handling_Age_Throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age=0;
            try
            {

                Console.WriteLine("Enter Age ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age<18)
                {
                    throw new Exception("Age Must Be 18 or Greater than 18");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Enter Small Number");
                age=Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Enter Age 18 or Greater than 18");
                age = Convert.ToInt32(Console.ReadLine());
            }

            finally
            {
                Console.WriteLine("Finally Block is Executing");
                Console.WriteLine("Age : " + age);
                Console.WriteLine("Bye");
            }
            Console.ReadKey();
        }
    }
}
