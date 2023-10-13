using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Height_Is_Drawf_Short_Tall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cm;

            Console.WriteLine("Enter Height in Centimeter");
            cm = Convert.ToInt32(Console.ReadLine());

            if (cm <= 150)
            {
                Console.WriteLine("The Person is Drawf");
            }
            else if(cm <=165 && cm >150 )
            {
                Console.WriteLine("The Person Has Average Height");
            }
            else if (cm <= 195 && cm > 165)
            {
                Console.WriteLine("The Person is Taller");
            }
            else
            {
                Console.WriteLine("Abnormal Height");
            }
            Console.ReadKey();
        }
    }
}