using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ReadLine fonksiyonu ile kullanicidan input alacagiz

            Console.Write("Please enter your name : ");
            String firstName = Console.ReadLine();

            Console.Write("Please enter your last name : ");
            String lastName = Console.ReadLine();

            Console.WriteLine("FirstName : " + firstName);
            Console.WriteLine("LastName : " + lastName);

            Console.ReadLine();

        }
    }
}
