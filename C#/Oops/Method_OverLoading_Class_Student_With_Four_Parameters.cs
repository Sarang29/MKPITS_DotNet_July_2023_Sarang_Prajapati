using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_OverLoading_Class_Student_With_Four_Parameters
{
    class Student
    {
        int RollNo;
        string Name;
        string Course;
        int Fees;

        public void getdata()
        {
            RollNo = 1;
            Name = "Sarang";
            Course = "Dotnet";
            Fees = 5000;
        }

        public void getdata(int RollNo)
        {
            this.RollNo = RollNo;
        }

        public void getdata(int RollNo,string Name)
        {
            this.RollNo = RollNo;
            this.Name = Name;
        }

        public void getdata(int RollNo,string Name,string Course)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Course = Course;
        }

        public void getdata(int RollNo,string Name,string Course,int Fees)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Course = Course;
            this.Fees = Fees;
        }

        public void display()
        {
            Console.WriteLine("Student Roll Number : " + RollNo);
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Student Course : " + Course);
            Console.WriteLine("Student Fees : " + Fees);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.getdata();
            student1.display();

            Student student2 = new Student();
            student2.getdata(2);
            student2.display();

            Student student3 = new Student();
            student3.getdata(3,"Akash");
            student3.display();

            Student student4 = new Student();
            student4.getdata(4, "Lucky", "Java");
            student4.display();

            Student student5 = new Student();
            student5.getdata(5, "David", "PHP", 4000);
            student5.display();

            Console.ReadKey();
        }
    }
}
