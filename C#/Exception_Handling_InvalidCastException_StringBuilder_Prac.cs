using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_InvalidCastException_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sarang");
            Console.WriteLine("Sb = "+sb.ToString());

            object obj = sb;
            Console.WriteLine("Obj = "+obj.ToString());

            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Byee");
            Console.ReadKey();
        }
    }
}
