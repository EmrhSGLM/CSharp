using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Intro();
            string sentence = "My name is Emrah Sağlam";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Mehmet Sağlam";

            bool result3 = sentence.EndsWith("m");
            bool result4 = sentence.StartsWith("M");

            var result5 = sentence.IndexOf("name"); // name kacıncı indeks ten baslar onu doner (bulamazsa-1 doner) 
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");// aramaya sondan baslar
            var result8 = sentence.Insert(0, "Hello ");// o index e elemanı ekler
            var result9 = sentence.Substring(3); // Metni parcalamak icin ise yarar.
            var result10 = sentence.Substring(3,4); // 3. karakterden itibaren 4 eleman al
            var result11 = sentence.ToLower(); // lowerCase
            var result12 = sentence.ToUpper(); // upperCase
            var result13 = sentence.Replace(" ", "-"); // bosluk yerine - yaz
            var result14 = sentence.Remove(2); // 2.Elemandan itibaren sil
            var result15 = sentence.Remove(2,5); // 2.Elemandan itibaren 5 eleman sil

            Console.WriteLine(result15);
           
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city1 = "Ankara"; // string bir char array dir
            //Console.Write(city1[0]);

            foreach (var item in city1)
            {
                Console.WriteLine(item);
            }

            string city2 = "Istanbul";
            string result = city1 + city2;

            Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city1, city2));

        }
    }
}
