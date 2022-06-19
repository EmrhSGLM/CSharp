using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinueKeyUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Break And Continue Using

            for(int i = 1; i<=10; i++)
            {
                if(i == 7)
                {
                    //break; // loop tamamen kirar
                    continue; // calistigi yerde kod blogu calisma durur ve loop en basa doner
                }
                Console.WriteLine("i'nin degeri : " + i);
            }
            Console.ReadLine();
        }
    }
}
