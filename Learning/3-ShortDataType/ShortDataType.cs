using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortDataType
{
    internal class ShortDataType
    {
        static void Main(string[] args)
        {
            // short degiskeni -32768 ile 32767 arasinda deger depolayabilmektedir

            short maxValue = short.MaxValue;
            short minValue = short.MinValue;

            Console.WriteLine("Max Value =>" + maxValue);
            Console.WriteLine("Min Value =>" + minValue);
            Console.ReadLine();
        }
    }
}
