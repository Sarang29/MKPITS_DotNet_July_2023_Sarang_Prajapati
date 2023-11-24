using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HastTable_Movie_and_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("2001", "Murder");
            ht.Add("2018", "Sacred Games");
            ht.Add("2020", "Scam 2003");

            if(ht.ContainsValue("Scam 2003"))
            {
                Console.WriteLine("This Movie Already Exist in List");
            }
            else
            {
                ht.Add("2020", "Scam 2003");
            }

            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k +":"+ht[k]);
            }

            Console.ReadKey();
        }
    }
}
