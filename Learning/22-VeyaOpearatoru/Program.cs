using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeOpearatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Veya operatoru : || 

            int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 6;

            bool control = sayi1 == sayi2 || sayi2 > sayi3;

            Console.WriteLine(control);
            Console.ReadLine();
        }
    }
}
