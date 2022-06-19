using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10 a kadar olan sayilari ekrana yazdirin

            // 100 den 0 a kadar olan sayilarin cift olanlarini buyukten kucuge yazdirin

            int a = 1;
            /*
            while ( a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadLine();
            */


            int b = 100;
            while ( b >= 0 )
            {
                Console.WriteLine(b);
                b -= 2 ; // b=b-2;
            }
            Console.ReadLine();

        }
    }
}
