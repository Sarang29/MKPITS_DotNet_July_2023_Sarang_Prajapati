using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastTable_Singer_and_Song
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("KK", "Dil Ibadat");
            ht.Add("Arijit", "Kaise Hua");
            ht.Add("Honey Singh", "Brown Rang");
            ht.Add("Sidhu SamoseWala", "Never Fold");

            if(ht.ContainsValue("Chelaya"))
            {
                Console.WriteLine("Already Exist");
            }
            else
            {
                ht.Add("Sunidhi", "Chelaya");
            }

            ICollection col = ht.Keys;

            foreach(string val in col)
            {
                Console.WriteLine(val + ":" + ht[val]);
            }
            Console.ReadKey();
        }
    }
}
