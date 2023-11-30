using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_User_Defined_Exception_Class_Vovels
{
    class VovelException:ApplicationException
    {
        public VovelException(string message) : base(message)
        {

        }
    }

    class vovel
    {
        public char c;

        public void showchar(char c)
        {
            if (c == 'a')
            {
                Console.WriteLine("It is Vovel");
            }
            else if (c == 'e')
            {
                Console.WriteLine("It is Vovel");
            }
            else if(c == 'i')
            {
                Console.WriteLine("It is Vovel");
            }
            else if (c == 'o')
            {
                Console.WriteLine("It is Vovel");
            }
            else if (c == 'u')
            {
                Console.WriteLine("It is Vovel");
            }
            else
            {
                throw new VovelException("Character Should be a,e,i,o,u");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            vovel v = new vovel();
            Console.WriteLine("Ener Character");
            char c = Convert.ToChar(Console.ReadLine());
            try
            {
                v.showchar(c);
            }
            catch(VovelException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("Byee");
            Console.ReadKey();
        }
    }
}
