using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_Fields_Class_Honda_Deri_From_Class_Car
{
    class Car
    {
        public string model;
        public string make;
    }

    class Honda:Car
    {
        public string Color;
        public int year;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Honda h1 = new Honda();

            h1.make = "Honda";
            h1.model = "City";
            h1.Color = "Silver";
            h1.year = 2019;

            Console.WriteLine("Car Brand : " + h1.make);
            Console.WriteLine("Car Model : " + h1.model);
            Console.WriteLine("Car Colour : " + h1.Color);
            Console.WriteLine("Car Manufacturing Year : " + h1.year);

            Console.ReadKey();
        }
    }
}
