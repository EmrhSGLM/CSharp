using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beden Kitle Endeksi = Kilo / boy*boy
            // Beden Kitle Endeksi 18 ' e esit veya dusukse ZAYIF
            // 18 ile 25 arasındaysa NORMAL
            // 25'ten buyukse OBEZ yazdiran program parcasini kodlayiniz

            Console.Write("Lutfen kilonuzu giriniz : ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lutfen boyunuzu giriniz : ");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke <= 18)
            {
                Console.WriteLine("ZAYIF");
            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("NORMAL");

            }
            else if (bke >= 25)
            {
                Console.WriteLine("OBEZ");
            }
            Console.ReadLine();

        }
    }
}
