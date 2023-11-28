using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_LinkedList_Add_and_Find_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddFirst(6);
            list.AddFirst(7);

            LinkedListNode<int> node = list.Find(3);
            list.AddBefore(node,10);

            foreach(int li in list)
            {
                Console.WriteLine(li);
            }

            Console.ReadKey();
        }
    }
}
