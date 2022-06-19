using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsittirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // == : Esittir Operatoru

            int sayi1 = 4;
            int sayi2 = 5;
            int sayi3 = 5;

            bool control = sayi1 == sayi2;
            bool control1 = sayi3 == sayi2;

            Console.WriteLine(control); // False
            Console.WriteLine(control1); // True
            Console.ReadLine();


        }
    }
}
