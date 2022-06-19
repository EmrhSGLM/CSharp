using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDataType
{
    internal class IntDataType
    {
        static void Main(string[] args)
        {

            //Int Data type -2.147.483.648 ile 2.147.483.647 arasinda deger depolayabilmektedir
            // 4 byte yer kaplar ram bellekte

            // 8 bit = 1 byte
            // 1024 byte = 1KB (kilobyte)
            // 1024 KB = 1MB (megabyte)
            // 1024 MB = 1GB(gigabyte)
            // 1024 GB = 1TB(terabyte)
            // 1024 TB = 1 PB (petabyte)

            int birinciDegisken = 150000; // altini yesil cizmesi kullnilmadigi ifade eder

            int ikinciDegisken = -500000;

            int maxValue = int.MaxValue;
            int minValue = int.MinValue;

            Console.WriteLine(birinciDegisken);
            Console.WriteLine(ikinciDegisken);

            Console.WriteLine("Max Value => " + maxValue);
            Console.WriteLine("Min Value => " + minValue);

            Console.ReadLine();
        }
    }
}
