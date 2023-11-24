using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Char_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Sarang");
            q.Enqueue("Lucky");
            q.Enqueue("Akash");
            q.Enqueue("David");
            q.Enqueue("Chetan");

            foreach(string og in q)
            {
                Console.WriteLine("Names : "+og);
            }
            Console.WriteLine();

            q.Enqueue("Ashwin");
            q.Enqueue("Sujit");
            Console.WriteLine("Added Enqueue List");
            foreach(string og in q)
            {
                Console.WriteLine("Names : " + og);
            }
            Console.WriteLine();


            Console.WriteLine("Dequeued List");
            string ch = (string)q.Dequeue();
            Console.WriteLine("Removed name : {0}",ch);

            ch = (string)q.Dequeue();
            Console.WriteLine("New Removed Name : {0}", ch);

            foreach(string og in q)
            {
                Console.WriteLine("Names : " + og);
            }



            Console.ReadKey();


        }
    }
}
