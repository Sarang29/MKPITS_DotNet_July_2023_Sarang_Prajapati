 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Sarang");
            sb.Append("Lucky");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
