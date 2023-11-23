using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Class_ArrayList_Phone_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList PhoneNumber = new ArrayList();
            PhoneNumber.Add(7378875024);
            PhoneNumber.Add(9764066004);
            PhoneNumber.Add(6871387459);
            PhoneNumber.Add(6498789674);

            foreach(object pno in PhoneNumber)
            {
                Console.WriteLine("Phone Numbers : " + pno);
            }
            Console.ReadLine();

        }
    }
}
