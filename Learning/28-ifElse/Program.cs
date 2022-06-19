using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ogrencinin notu 50 den buyukse basarili degilse basarisiz yazdiran program ciktisini kodlayiniz

            int not = 75;

            if (not > 50)
            {
                Console.WriteLine("Ogrenci Basarili");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ogrenci Basarisiz");
                Console.ReadLine();
            }
            // Ya if bloklari ya da else bloklari calisir 
            // İkisi birden calismaz

        }
    }
}
