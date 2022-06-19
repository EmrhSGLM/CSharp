using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(20);

            //int number1 = 10;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);
            //Console.WriteLine("result : " + result);
            //Console.WriteLine("number1 : " + number1);
            //Console.WriteLine("result2 : "+ result2);

            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Multiply(2,3,4));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();            

        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int number1, int number2=30)
        // number2 Default parametre, Default son parametre olmalıdır,
        // Eger def par. deger atanırsa atanan degeri kullanır
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(out int number1, int number2)
        {
            // ref tip olarak yaparsan yapılan degisiklik her yerde ki degerde degisir.
            // out keyword aynı sekilde kullanılabilir
            // out un ref den farkı out da variable ilk deger atamasını yapmayabiliriz
            // out gonderilen variable method un icinde assign edilmesi gerekir.
            
            number1 = 30;
            return number1+ number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3) // Method Overloading
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers) // Java daki varargs
        {
            return numbers.Sum();
        }



    }
}
