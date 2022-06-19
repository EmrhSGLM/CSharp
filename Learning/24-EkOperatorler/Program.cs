using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkOperatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // +=
            // -=
            // /=
            // *=

            int a = 10; int b = 12; int c = 2; 

            // a = a+4; => a+=4;
            a += 4;
            Console.WriteLine("a' nin degeri : " + a);

            b /= 2;
            Console.WriteLine("b' in degeri : " + b);

            c *= 6;
            Console.WriteLine("c' nin degeri : " + c);

            Console.ReadLine();
        }
    }
}
