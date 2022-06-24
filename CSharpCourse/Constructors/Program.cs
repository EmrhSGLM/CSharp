using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {

        static Program()
        {
            // class da en once calısmasını istedigimiz isler varsa bu sekilde yapariz
            Console.WriteLine("static blok");
        }
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();
            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.List();

            Product product = new Product(1, "Laptop");
            Product product2 = new Product(2, "Computer");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();


            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;

            Utilities.Validate();

            Manager.DoSomething();

            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();

        }
    }

    class CustomerManager
    {

        private int _count = 15; // field alt cizgi ile baslatilir

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

    class Product
    {
        public Product()
        {
                
        }

        private int _id;
        private string _name;
        public Product(int id, string name )
        {
            _id = id;
            _name = name;
        }

        public int Id {get;set;}
        public string Name {get;set;}
    }

    interface ILogger
    {
        void Log();
    }

    class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!!!");
        }

    }

    class BaseClass
    {
        private string _entity;
        private string name = "Emrah";

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class PersonManager: BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }

    }

    static class Teacher
    {
        // static nesnelere her yerden ulasılır
        // static nesnelerde yapılan degisiklik tum heryeri etkiler
        public static int Number { get; set; }
    }

    static class Utilities // validasyonlar icin kullanilabilir
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public  void DoSomething2()
        {
            Console.WriteLine("Done 2");

        }
    }

    



}
