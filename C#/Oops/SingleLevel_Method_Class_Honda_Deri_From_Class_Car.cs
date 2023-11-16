using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_Method_Class_Honda_Deri_From_Class_Car
{
    class Car
    {
        public void start()
        {
            Console.WriteLine("Car is Start");
        }
    }

    class Honda : Car
    {
        public void stop()
        {
            Console.WriteLine("Car is Stop");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Honda h1 = new Honda();

            h1.start();
            h1.stop();

            Console.ReadKey();

        }
    }
}
