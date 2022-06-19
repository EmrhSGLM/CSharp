using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsitDegildirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Esit degildir Operator : !=

            int sayi1 = 1;
            int sayi2 = 8;
            int sayi3 = 8;
            bool control = sayi1 != sayi2;
            bool control1 = sayi3 != sayi2;
            Console.WriteLine(control);
            Console.WriteLine(control1);
            Console.ReadLine();

        }
    }
}
