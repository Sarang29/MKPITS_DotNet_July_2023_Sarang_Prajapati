using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Class_ArrayList_Class_Student
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
            Student s1 = new Student(1,"Sarang");
            Student s2 = new Student(2,"Lucky");
            Student s3 = new Student(3,"Akash");
            ArrayList ar = new ArrayList();
            ar.Add(s1);
            ar.Add(s2);
            ar.Add(s3);

            foreach (Student s in ar)
            {
                Console.WriteLine("Student Roll No : " + s.rollno + "\n");
                Console.WriteLine("Student Name : " + s.name + "\n");
            }

            Console.ReadKey();
        }
    }
}
