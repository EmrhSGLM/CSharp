﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(23);
            customerManager.List();
            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.List();



            Console.ReadLine();

        }
    }

    class CustomerManager
    {

        private int _count = 71; // field alt cizgi ile baslatilir

        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed! {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }


    }
}
