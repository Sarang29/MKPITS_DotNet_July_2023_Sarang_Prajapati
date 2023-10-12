using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wap_Acpt_Char_From_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char k;
            Console.WriteLine("Enter Character");
            k = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Character is "+k);
            Console.ReadKey();
        }
    }
}
