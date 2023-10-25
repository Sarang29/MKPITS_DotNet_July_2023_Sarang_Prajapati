using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Statement_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (true)
            {
                Console.WriteLine(i);
                i++;
                if (i <= 15)
                {
                    continue;
                }
                else
                {
                    break;
                }
            
            }
            Console.ReadKey();
            }
        }
    }

