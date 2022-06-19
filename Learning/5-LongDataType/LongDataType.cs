using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongDataType
{
    internal class LongDataType
    {
        static void Main(string[] args)
        {
            // long veri tipi -9,233,372,036,854,775,808 to 9,223,372,036,854,775,807 arasında deger depolayabiliriz
            // 8 byte yer kaplar ram bellekte

            long firstVariable = 575000;

            long secondVariable = -500;

            long Max = long.MaxValue;

            long Min = long.MinValue;

            Console.WriteLine(firstVariable);
            Console.WriteLine(secondVariable);
            Console.WriteLine("Max => " + Max);
            Console.WriteLine("Min => " + Min);

            Console.ReadLine();


        }
    }
}
