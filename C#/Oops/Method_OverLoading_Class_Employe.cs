using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_OverLoading_Class_Employe
{
    class Employe
    {
        int EmployeId;
        string EmployeName;

        public void getdata()
        {
            EmployeId = 1;
            EmployeName = "Lucky";
        }

        public void getdata(int EmployeId, string EmployeName)
        {
            this.EmployeId = EmployeId;
            this.EmployeName = EmployeName;
        }

        public void display()
        {
            Console.WriteLine("Employe Id : " + EmployeId);
            Console.WriteLine("Employe Name : " + EmployeName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe = new Employe();

            employe.getdata();
            employe.display();

            Employe employe1 = new Employe();
            employe1.getdata(2,"Akash");
            employe1.display();

            Console.ReadKey();
        }
    }
}
