using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_List_Language
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = new List<string>();

            langs.Add("Java");
            langs.Add("C#");
            langs.Add("C");
            langs.Add("C++");
            langs.Add("Ruby");
            langs.Add("Javascript");

            Console.WriteLine(langs.Contains("C#"));

            Console.WriteLine(langs[1]);
            Console.WriteLine(langs[2]);

            langs.Remove("Csharp");
            langs.Remove("C++");

            Console.WriteLine(langs.Contains("Csharp"));

            langs.Insert(3, "Python");

            langs.Sort();

            foreach (string language in langs)
            {
                Console.WriteLine(language);
            }
            Console.ReadKey();

        }
    }
}
