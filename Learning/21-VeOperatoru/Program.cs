using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeOperaoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // && ve opeartoru 

            int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 9;

            bool control = sayi1 == sayi2 && sayi2 < sayi3;
            Console.WriteLine(control);
            Console.ReadLine();
        }
    }
}
