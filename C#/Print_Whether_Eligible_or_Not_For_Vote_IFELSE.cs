using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Whether_Eligible_or_Not_For_Vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());

            if(age > 18)
            {
                Console.WriteLine("You Are Eligible For Vote");
            }
            else
            {
                Console.WriteLine("You Are Not Eligible For Vote");
            }
            Console.ReadKey();
        }
    }
}
