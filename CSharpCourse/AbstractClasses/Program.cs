using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstract class lar dan obje uretilmez
            DataBase database = new SqlServer();
            database.Add();
            database.Delete();  
            
            DataBase database2 = new Oracle();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }

    abstract class DataBase
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Dleted by Sql");
        }
    }

    class Oracle : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Dleted by Oracle");
        }
    }



}
