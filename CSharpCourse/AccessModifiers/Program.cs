using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        protected int id { get; set; }

        public void Save()
        {
            id = 10;
        }

        public void Delete()
        {

        }
    }

    class Student:Customer
    {
        public void Save2()
        {
            id++;
        }
    }

    public class Course // bir class'in default hali internal dir.
    {
        public string Name { get; set; }

        private class NestedClass
        {
            // Sadece bu Course class icin de kullanılabilir
        }
    }
}
