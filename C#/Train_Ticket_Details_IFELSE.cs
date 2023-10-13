using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Ticket_Details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origin, destination, passengername, cls,tname,ans;
            int date, no, km;

            Console.WriteLine("Enter Origin");
            origin = Console.ReadLine();

            Console.WriteLine("Enter Destination");
            destination = Console.ReadLine();

            Console.WriteLine("Enter Train Name");
            tname = Console.ReadLine();

            Console.WriteLine("Enter Date");
            date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Passenger No.");
            no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Passenger Name");
            passengername = Console.ReadLine();

            Console.WriteLine("Enter Kilometer");
            km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Enter Class");
            cls =Console.ReadLine();

            if (km <= 100)
            {
                ans="Total Fare is 100";
            }
            else if (km <= 500 && km > 100)
            {
                ans="Total Fare is 500";
            }
            else if (km > 500 && km <= 1000)
            {
                ans="Total Fare is 1000";
            }
            else
            {
                ans="You Entered Invalid Kilometers";
            }

                Console.WriteLine("Origin = {0},\nDestination = {1},\nTrain Name = {2},\nDate = {3},\nEnter Passenger Name = {4},\nClass = {5}",origin,destination,tname,date,passengername, cls);
                Console.WriteLine(ans);
                Console.ReadKey();

        }
    }
}
