using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_One_Or_More_Main_Example
{
    class Student
    {
        public static int Id;

        public static void display()
        {
            Console.WriteLine("Hello From Display Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Student.Id = 123;
            Console.WriteLine("Book Id : " + Student.Id);

            Program p = new Program();
            p.Main();
        }

           void Main()
            {
                Console.WriteLine("Hello From Another Main Method");
            }

        }
    }

