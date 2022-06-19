using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopPractise
{
    internal class Program
    {

        static int number;
        static int sum;
        static void Main(string[] args)
        {
            // Kullanicidan bir sayi alin 1'dan baslayip aldiginiz sayiya kadar toplayacagiz ve girdigi sayiyi
            // bolecegiz eger ortalama 50 den buyuk ise ortalama 50 den buyuktur
            // degilse ortalama 50 den kucuktur yazdirin


            while (true)
            {
                Console.WriteLine("Pozitif bir sayi giriniz ");
                number = Convert.ToInt32(Console.ReadLine());
                if(number > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatali giris yaptiniz !!! ");
                }

            }
            
            for(int i=1; i <= number ; i++)
            {
                sum += i;
            }
            double ort = sum / (number );
            if (ort > 50)
            {
                Console.WriteLine("Ortalama 50 den buyuktur");
            }
            else
            {
                Console.WriteLine("Ortalama 50 den kucuktur");
            }
            Console.ReadLine();


        }
    }
}
