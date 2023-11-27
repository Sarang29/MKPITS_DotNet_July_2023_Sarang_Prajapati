using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = new List<string>();
            langs.Add("Csharp");
            langs.Add("Java");
            langs.Add("PHP");
            langs.Add("Python");

            Console.WriteLine(langs.Contains("Ruby"));

            Console.WriteLine(langs[0]);
            Console.WriteLine(langs[1]);

            foreach(string s in langs)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
