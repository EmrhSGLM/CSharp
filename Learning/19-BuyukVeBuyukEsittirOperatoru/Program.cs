using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukVeBuyukEsittirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buyuktur operatoru : >
            // Buyuk ve Esittir operatoru : >=

            int kilo = 20;

            bool control = kilo > 21;
            bool control2 = kilo >= 20;

            Console.WriteLine(control); // False
            Console.WriteLine(control2); // True
            Console.ReadLine();

        }
    }
}
