using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Interface_IReadable_and_IWriteable_With_Two_Method
{
    interface IReadable
    {
        void ReadData();
        void WriteData(string Data);
    }

    interface IWritable
    {
        void ReadData();
        void WriteData(string Data);
    }

    class FileHandler: IReadable, IWritable
    {
        public void ReadData()
        {
            Console.WriteLine("Data Readed...");
        }

        public void WriteData(string Data)
        {
            Console.WriteLine(Data);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IReadable readable = new FileHandler();
            readable.ReadData();
            readable.WriteData("Nagpur");

            IWritable writable = new FileHandler();
            writable.ReadData();
            writable.WriteData("Mumbai");

            Console.ReadKey();
        }
    }
}
