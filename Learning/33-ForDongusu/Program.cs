using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10 a kadar olan sayilari alt alta ekrana yazdiran programi kodlayiniz

            /*for(int i=1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            // 1 den 10 a kadar olan sayilardan cift olanlarini ekrana yazdirmak istiyorum
            for(int i=0; i <= 10; i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
