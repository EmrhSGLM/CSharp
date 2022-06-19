using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Float ondalık sayilar kullanmamız icin kullanilan veri tipi

            float firstVariable = 0.5f;

            float secondVariable = 35.55f;

            float Max = float.MaxValue;
            //float Min = float.MinValue();

            Console.WriteLine(firstVariable);
            Console.WriteLine(secondVariable);

            Console.WriteLine("Max => " + Max);
            //Console.WriteLine("Min => " + Min);
            Console.ReadLine();
        }
    }
}
