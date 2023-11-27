using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_Language_Insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = new List<string>();

            langs.Add("MongoDB");
            langs.Add("Java");
            langs.Add("Dotnet");
            langs.Add("PHP");
            langs.Add("Csharp");

            langs.Insert(3, "SQL");

            foreach (string s in langs)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
