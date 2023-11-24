using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_MovieName_ReleaseYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("2023", "Jawan");
            sl.Add("2022", "Pathan");
            sl.Add("2021", "War");
            sl.Add("2020", "Titanic");
            sl.Add("2019", "Mirzapur");

            if (sl.ContainsValue("Mission"))
            {
                Console.WriteLine("Already Exists in List");
            }
            else
            {
                sl.Add("2017", "Mission");
            }

            ICollection key = sl.Keys;

            foreach(string movie in key)
            {
                Console.WriteLine(movie + ":" + sl[movie]);
            }

            Console.ReadKey();
        }
    }
}
