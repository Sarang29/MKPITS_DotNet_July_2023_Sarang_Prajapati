using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Vehicle_Inheritance_Practice_Ques_New
{

    class Vehicle
    {
        public int make;
        public string model;
    }
    class Car : Vehicle
    {
        public int No_Of_Doors;
        public string Fuel_Type;
        public void getdata(int make,string model,int No_Of_Doors,String Fuel_Type)
        {
            this.make = make;
            this.model = model;
            this.No_Of_Doors = No_Of_Doors;
            this.Fuel_Type = Fuel_Type;
        }
        public void display()
        {
            Console.WriteLine("Make : " + make);
            Console.WriteLine("Model : " + model);
            Console.WriteLine("No Of Doors : " + No_Of_Doors);
            Console.WriteLine("Fuel Type : " + Fuel_Type);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.getdata(2020, "Honda", 5, "Petrol");
            c.display();

            Console.ReadKey();
        }
    }
}
