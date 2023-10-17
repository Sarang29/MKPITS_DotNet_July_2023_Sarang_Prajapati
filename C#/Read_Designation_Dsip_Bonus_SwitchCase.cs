using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Designation_Dsip_Bonus_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string designation;
            int bonus=0;

            Console.WriteLine("Enter Designation");
            designation = Console.ReadLine();

            switch (designation)
            {
                case "manager":
                    
                        bonus = 10000;
                        break;
                    
                case "clerk":
                    
                        bonus = 5000;
                        break;
                    
                case "peon":
                    
                        bonus = 2000;
                        break;
                    
                default:
                  
                        Console.WriteLine("Invalid Designation");
                        break;
                    }
                    Console.WriteLine("Bonus = {0}",bonus);
            
                    Console.ReadKey();

          
        }
    }
}
