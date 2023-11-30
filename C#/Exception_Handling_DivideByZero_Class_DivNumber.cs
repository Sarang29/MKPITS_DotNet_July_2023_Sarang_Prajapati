using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_DivideByZero_Class_DivNumber
{
    class DivNumber
    {
        public int result = 0;

        public void GetNumber(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine(result);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                DivNumber d = new DivNumber();
                d.GetNumber(25, 0);
                Console.WriteLine("Byee");
                Console.ReadKey();
            }
        }
    }
}
