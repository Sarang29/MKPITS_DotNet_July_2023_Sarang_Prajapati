using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_User_Defined_Exception_Temperature
{
    class TemperatureIsZeroException : ApplicationException
    {
        public TemperatureIsZeroException(string message):base(message)
        {

        }

    }

    class Temperature
    {
        public int temp=0;
        public void ShowTemp()
        {
            if (temp == 0)
            {
                throw new TemperatureIsZeroException("Zero is Found");
            }
            else
            {
                Console.WriteLine("Temperature : " + temp);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature();
            try
            {
                t.ShowTemp();
            }
            catch (TemperatureIsZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Byee");
            Console.ReadKey();
        }
    }
}
