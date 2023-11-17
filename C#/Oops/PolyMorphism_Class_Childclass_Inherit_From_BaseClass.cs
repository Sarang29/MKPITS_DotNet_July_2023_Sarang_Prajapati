using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism_Class_Childclass_Inherit_From_BaseClass
{
    class Baseclass
    {
        public virtual void display()
        {
            Console.WriteLine("Hello From Base CLass");
        }
    }

    class Childclass:Baseclass
    {
        public override void display()
        {
            Console.WriteLine("Hello From ChildClass");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Baseclass b = new Childclass();

            b.display();

            Console.ReadKey();
        }
    }
}
