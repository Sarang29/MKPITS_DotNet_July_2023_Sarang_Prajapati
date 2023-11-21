using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Interface_Cls_ILogger_With_Two_Method
{
    interface ILogger
    {
        string LogMessage();
        string LogError();
    }

    class ConsoleLogger
    {
        public string LogMessage()
        {
            return "Hello From Log Message";
        }

        public string LogError()
        {
            return "Hello From Log Error";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();
            string res = logger.LogMessage();
            Console.WriteLine(res);

            res = logger.LogError();
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
