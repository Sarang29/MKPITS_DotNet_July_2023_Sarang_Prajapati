using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Class_Student
{
    class Student
    {
        public int rollno;
        public string name;

        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(123, "Sarang");
            Student s2 = new Student(456, "Lucky");
            Student s3 = new Student(789, "David");

            Queue queue = new Queue();
            queue.Enqueue(s1);
            queue.Enqueue(s2);
            queue.Enqueue(s3);

            foreach(Student s in queue)
            {
                Console.WriteLine("Roll Number : " + s.rollno);
                Console.WriteLine("Students Names : " + s.name);
            }
            Console.WriteLine();

            Student r = (Student)queue.Dequeue();
            Console.WriteLine("Removed Roll no : " + r.rollno + "\nRemoved Name : " + r.name);

            Console.WriteLine();
            foreach(Student s in queue)
            {
                Console.WriteLine("Roll Number : " + s.rollno);
                Console.WriteLine("Student Name : " + s.name);
            }
            Console.ReadKey();
        }
    }
}
