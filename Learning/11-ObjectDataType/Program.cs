using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object veri tiplerinin atasi dir. 
            
            int a = 5;
            String name = "Emrah";
            object obj = name;
            Console.WriteLine("String => " + obj);
            obj = a;
            Console.WriteLine("int => " + obj);
            Console.ReadLine();
        }
    }
}
