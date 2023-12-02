using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_OutofMemoryException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sarang";
            string location = "Maharashtra";
            Console.WriteLine("Length of Name : "+name.Length);
            StringBuilder sb = new StringBuilder(name.Length,name.Length);
            try
            {
                sb.Append(location);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Byee");
            Console.ReadKey();
        }
    }
}
