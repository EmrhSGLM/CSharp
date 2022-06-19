using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtirmaVeAzaltmaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Artirma Operatoru : ++
            // Azaltma Operatoru : --

            int sayi1 = 10;
            Console.WriteLine(sayi1++); // 10
            Console.WriteLine(++sayi1); // 12

            Console.WriteLine(sayi1--); // 12
            Console.WriteLine(--sayi1); // 10 

            Console.ReadLine();
        }
    }
}
