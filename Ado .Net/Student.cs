using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_StudentClass_Information
{
    internal class Student
    {
        public int rno { get; set; }
        public string studname { get; set; }
        public string gender { get; set; }
        public string hobby { get; set; }
        public string city { get; set; }
        public string dob { get; set; }

        public Student(int rno, string studname, string gender,string hobby, string city, string dob)
        {
            this.rno = rno;
            this.studname = studname;
            this.gender = gender;
            this.hobby = hobby;
            this.city = city;
            this.dob = dob;
        }
    }
}
