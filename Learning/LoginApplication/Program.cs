using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApplication
{
    internal class Program
    {

        static String username = "emrah7168";
        static String password = "emrah7168";
        static void Main(string[] args)
        {
            // Kullanici giris sayfasi uygulamasi yapacagiz
            // Kullanici adi ve sifresini dogru girerse Tebrikler basarili bir sekilde giris yaptiniz
            // Yanlis girerse hata verelim ve 3 hak taniyalim kullaniciya yanlis girdigi surece
            //                  dongu donmeye devam etsin
            int a = 0;
            while (true)
            {
                Console.Write("Enter username : ");
                String username1 = Console.ReadLine();
                Console.Write("Enter password : ");
                String password1 = Console.ReadLine();
                if(username1 == username && password1 == password)
                {
                    Console.WriteLine("Tebrikler basarili bir sekilde giris yaptiniz :) ");
                    break;
                }
                Console.WriteLine("Hatali giris yaptiniz ! ");
                a++;
                if(a == 3)
                {
                    Console.WriteLine("Kartiniz bloke oldu");
                    break;
                }


            }
            Console.ReadLine();
        }
    }
}
