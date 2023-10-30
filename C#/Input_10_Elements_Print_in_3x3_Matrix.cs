using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_10_Elements_Print_in_3x3_Matrix
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
          
            int[,] arr1 = new int[3,3];
            

            Console.WriteLine("Enter 9 Elements : ");
            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i=0;i<3; i++)
            {
                for(int j=0; j<3;j++)
                {
                    Console.Write(arr1[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
