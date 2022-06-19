using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

            double number5 = 10.4;
            decimal number6 = 10.6m; // ondalıklı sayi oldugunda sonuna m harfinin konmasi gerekir

            char character = 'E'; // ASCII  
            String city = "Ankara";
            bool condition = true; // boolean kisaltmasi bool

            byte number4= 0; // 0 - 255 arası
            short number3 = 32767; // 16 bitlik yer kaplar
            int number1 = 10; // 32 bit lik yer kaplar
            long number2 = 214783647; // 64 bitlik yer kaplar

            var number7 = 10; // Bastan ne verildi ise o sekilde devam eder. 
            number7 = 'E';

            
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is : " + character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);

            Console.WriteLine((int)Days.Friday);

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday=32, Saturuday, Sunday 
    }
}
