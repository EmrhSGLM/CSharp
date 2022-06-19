using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulYapisiOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanicidan 3 tane not alan ve bu notlarin ortalamasini bulan ortalamasi
            // Eger 80 - 100 arasinda ise A+ yazdirin
            // 60 - 80 arasinda ise A yazdirin
            // 40 - 60 arasinda ise B+ yazdirin
            // 40 dan kucukse F yazdiran ornegi kod parcalarini yazdirin

            Console.Write("Lutfen 1. notu giriniz : ");
            int firstNote = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lutfen 2. notu giriniz : ");
            int secondNote = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lutfen 3. notu giriniz : ");
            int thirdNote = Convert.ToInt32(Console.ReadLine());

            int ortalama = (firstNote + secondNote + thirdNote) / 3;

            if (ortalama >= 80 && ortalama <= 100 )
            {
                Console.WriteLine("Notunuz : A+");
            }
            else if (ortalama >= 60 && ortalama < 80)
            {
                Console.WriteLine("Notunuz : A");
            }
            else if (ortalama >= 40 && ortalama < 60)
            {
                Console.WriteLine("Notunuz : B+");
            }
            else if(ortalama < 40)
            {
                Console.WriteLine("Notunuz : F");
            }

            Console.ReadLine();

        }
    }
}
