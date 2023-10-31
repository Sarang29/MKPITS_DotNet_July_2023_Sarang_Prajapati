using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Class_Student_Disp_Avg_Marks_of_Student
{
    class Student
    {
        string name;
        int roll_no;
        int[] marks = new int[5];
        int total = 0;
        float avg = 0;

        public void getdata(string name,int roll_no, int[] marks)
        {
            this.name = name;
            this.roll_no = roll_no;
            this.marks = marks;  
        }

        public void displaydata()
        {
            Console.WriteLine("Student Name = " + name);
            Console.WriteLine("Student Roll No = " + roll_no);

            for (int i = 0; i < marks.Length; i++)
            {
                total = total + marks[i];
            }
            Console.WriteLine("Total Marks = " + total);

            avg = total / marks.Length;
            Console.WriteLine("Average of Marks = " +avg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            Console.WriteLine("Enter Name & Roll");
            string n = Console.ReadLine();
            int r=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 5 Subject Marks");
            int[] m = new int[5];
            for(int i=0;i<5;i++)
            {
               m[i] = Convert.ToInt32(Console.ReadLine());
            }

            student1.getdata(n, r,m);

            student1.displaydata();

            Console.ReadKey();
        }
    }
}
