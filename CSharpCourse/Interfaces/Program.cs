using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = { new SqlServerCustomerDal(), new OracleCustomerDal(), new MySqlCustomerDal() };
            //ICustomerDal[] customerDals = new ICustomerDal[3] 
            //{ 
            //    new SqlServerCustomerDal(),
            //    new OracleCustomerDal(),
            //    new MySqlCustomerDal()
            //};

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }



            Console.ReadLine();
        }

        private static void Demo()
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Eda",
                LastName = "Saglam",
                Address = "Konya"
            };
            manager.Add(new Customer { Id = 1, FirstName = "Emrah", LastName = "Saglam", Address = "Konya" });
            manager.Add(customer);

            Student student = new Student
            {
                Id = 1,
                FirstName = "Amine",
                LastName = "Saglam",
                Departmant = "Computer Sciences"
            };
            manager.Add(student);

        }
    }

    // I interface anlamina gelir, Soyut nesne denir.
    //class lar somut nesne dir
    interface IPerson 
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

   
}
