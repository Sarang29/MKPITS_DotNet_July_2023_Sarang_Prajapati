using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor_Example_Class_Employe
{
    class Employe
    {
        public Employe()
        {
            Console.WriteLine("Constructor Called");
        }
        ~Employe()
        {
            Console.WriteLine("Destructor Called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe1 = new Employe();
            Console.ReadKey();

            Employe employe2 = new Employe();
            Console.ReadKey();
        }
    }
}
