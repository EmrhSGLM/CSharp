using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaVeCıkarmaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 5;
            int sayi2 = 25;
            int sayi3 = 35;

            int toplama = sayi1 + sayi2 + sayi3;
            Console.WriteLine("Toplama => " + toplama);
            int cıkarma = sayi3 - (sayi1 + sayi2);
            Console.WriteLine("Cikarma => " + cıkarma);
            Console.ReadLine();


        }
    }
}
