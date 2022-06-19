using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCasting_TurDonusumleri_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1.Example

            int a = 5;
            byte b = (byte) a;
            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            // 2.Example (String data type dan int data type donusturme)
            String sayi1 = "1";
            String sayi2 = "2";
            Console.WriteLine("String : " + (sayi1 + sayi2));

            int x = int.Parse(sayi1);
            int y = int.Parse(sayi2);
            Console.WriteLine("with Parse method : " + (x + y));

            int x1 = Convert.ToInt32(sayi1);
            int y1 = Convert.ToInt32(sayi2);
            Console.WriteLine("with Convert method : " + (x + y));

            // 3. Example (int data type dan string data type donusturme)
            int sayi3 = 5;
            int sayi4 = 10;
            Console.WriteLine("int : " + (sayi3 + sayi4));

            String str1 = sayi3.ToString();
            String str2 = sayi4.ToString();
            Console.WriteLine("String data type : " + str1 + str2);

            // 4. Example(Double dan int donusturme)
            double sayi5 = 5.22;
            Console.WriteLine(sayi5.GetType());

            int z = Convert.ToInt32(sayi5);
            Console.WriteLine(z.GetType());

            // Kullanicidan alinan degerler String Veri Tipinde Olur 

            String kullaniciYas = Console.ReadLine(); 
            // Kullanicidan alinan degerler her zaman String doner
            int kullaniciYasInt1 = int.Parse(kullaniciYas);
            int kullaniciYasInt2 = Convert.ToInt32(kullaniciYas);

            Console.WriteLine("kullaniciYasInt1  " + kullaniciYasInt1);
            Console.WriteLine("kullaniciYasInt2  " + kullaniciYasInt2);
            */

            // Kullanicidan 2 tane sayi alan ve ikisinini toplamini ekrana yazdiran programi yazdiriniz
            Console.WriteLine("Birinci sayi giriniz : ");
            String sayi1 = Console.ReadLine();

            Console.WriteLine("Ikinci sayiyi giriniz : ");
            String sayi2 = Console.ReadLine();

            int sayi1Int = int.Parse(sayi1);
            int sayi2Int = int.Parse(sayi2);

            Console.WriteLine("Iki sayinin toplami : " + (sayi1Int + sayi2Int));
            Console.ReadLine();

            // ToString();
            // ConvertToInt();
            // int.Parse();
            // double.parse();
            // (int)

        }
    }
}
