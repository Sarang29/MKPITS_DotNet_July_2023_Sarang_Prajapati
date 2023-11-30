using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_User_Defined_Exception_Class_Age
{
    class AgeException:ApplicationException
    {
        public AgeException(string message):base(message)
        {

        }
    }

    class Age
    {
        int age;

        public void eligible(int age)
        {
            if(age<18)
            {
                throw (new AgeException("Age Should be 18 or Greater than 18"));
            }
            else
            {
                Console.WriteLine("Age : "+age);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            Console.WriteLine("Enter Age ");
            int age=Convert.ToInt32(Console.ReadLine());
            try
            {
                a.eligible(age);
            }
            catch(AgeException ex) 
            {
                Console.WriteLine(ex.ToString());  
            }
            Console.WriteLine("Byee");
            Console.ReadKey();
        }
    }
}
