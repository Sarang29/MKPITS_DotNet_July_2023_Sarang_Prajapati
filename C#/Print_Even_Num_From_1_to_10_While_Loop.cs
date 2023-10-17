using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Even_Num_From_1_to_10_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while(counter<=10)
            {
                if(counter%2==0)
                {
                   
                    Console.WriteLine("{0} is Even",counter);
                  
                     
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}
