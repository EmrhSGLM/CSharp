using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEach();
            Console.WriteLine("Please enter a number : ");
            string number = Console.ReadLine();
            int num = int.Parse(number);

            if (IsPrimeNumber(num)){
                Console.WriteLine("Number is Prime Number!!!");
            }
            else
            {
                Console.WriteLine("Number is not Prime Number!!!");

            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!!!");
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }
        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 0);

        }
        private static void ForEach()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {// foreach bir veri tabanından data cektigimizde data da gezmek icin siklikla kullaniriz
                Console.WriteLine(student);
            }

        }
    }
}
