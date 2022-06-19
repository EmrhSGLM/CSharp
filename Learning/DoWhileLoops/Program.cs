using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10 a kadar olan sayilari do while ile yazdirin

            // 1 den 10 a kadar olan sayilarin toplamini ekrana yazdirin (do while)

            int a = 1;
            /*
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 10);
            */
            int toplam = 0;
            do
            {
                toplam += a;
                a++;
            } while (a <= 10);
            Console.WriteLine("1'den 10'a kadar olan sayıların TOPLAMI : " + toplam);
            Console.ReadLine();

        }
    }
}
