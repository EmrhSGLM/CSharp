using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseYapisi
{
    internal class Program
    {
        static int bakiye = 2500;
        
        static void Main(string[] args)
        {
            // Kullaniciya soracagiz nasil bir islem yapmak istedigini
            // 1- Bakiye Goruntuleme
            // 2- Para Cekme
            // 3- Para Yatirma
            // 4- Cikis Yap
            // 1-2-3-4 disinda bir deger girerse Hata verir

            Console.WriteLine("C# ATM'ye HosGeldiniz");
            Console.WriteLine("Yapabileceginiz Islemler : \n1- Bakiye Goruntuleme" +
                "\n2- Para Cekme \n3- Para Yatirma \n4- Cikis");
            Console.Write("Lutfen isleminizi seciniz : ");
            String secim = Console.ReadLine();

           switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz : " +bakiye);
                    break;

                case "2":
                    Console.WriteLine("Cekebileceginiz Max Tutar : " + bakiye);
                    Console.Write("Cekmek istediginiz tutari giriniz : ");
                    int cekilenTutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kalan Bakiye : " + (bakiye - cekilenTutar));
                    break;

                case "3":
                    Console.WriteLine("Yatiracaginiz tutari giriniz : ");
                    int yatirilanTutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Toplam Bakiyeniz : " + (bakiye + yatirilanTutar));
                    break;

                case "4":
                    Console.WriteLine("Gule gule ....");
                    break;

                default:
                    Console.WriteLine("Yanlis giris yaptiniz ...");
                    break;

            }

            Console.ReadLine();



        }

    }
}
