using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATMProjesi
{
    internal class Program
    {

        static int bakiye = 1500;
        static void Main(string[] args)
        {
            // Kullaniciya soracagiz nasil bir islem yapmak istedigini
            // 1- Bakiye Goruntuleme
            // 2- Para Cekme
            // 3- Para Yatirma
            // q ya basarsa cikis yapacagiz

            Console.WriteLine("Welcome to ATM \n Islemler : ");
            Console.WriteLine("1- Bakiye Goruntuleme \n2- Para Cekme \n3- Para Yatirma");
            Console.WriteLine("Yapmak istediginiz islemi seciniz : ");
            String secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Suanki Bakiyeniz : " + bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("Suanki bakiyeniz : " + bakiye);
                Console.WriteLine("Cekmek istediginiz tutari giriniz : ");
                int cekilecekTutar = Convert.ToInt32(Console.ReadLine());   

                int kalanBakiye = bakiye - cekilecekTutar;
                Console.WriteLine("Kalan Bakiye : " + kalanBakiye);

            }
            else if (secim == "3")
            {
                Console.Write("Yatiracaginiz tutari giriniz : ");
                int yatirilanTutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Toplam Bakiyeniz : " + (bakiye + yatirilanTutar));
            }
            else if (secim == "q")
            {
                Console.WriteLine("Gule gule Yine bekleriz ...!!! ");
            }
            else
            {
                Console.WriteLine("Lutfen gecerli bir deger giriniz ");
            }



            Console.ReadLine();


        }
    }
}
