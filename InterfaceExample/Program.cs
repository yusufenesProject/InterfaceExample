using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GetValue();
        }

        private static void GetValue()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new MySql());
            customerManager.Add(new SqlServer());
            customerManager.Add(new OracleServer());
            Console.Read();
        }

        interface ICustomer
        {
            void Add();
            void Update();
            void Delete();
        }

        class SqlServer:ICustomer
        {
            public void Add()
            {
                Console.WriteLine("SqlServer Added");
            }

            public void Update()
            {
                Console.WriteLine("SqlServer Updated");
            }

            public void Delete()
            {
                Console.WriteLine("SqlServer Deleted");
            }
        }

        class OracleServer: ICustomer
        {
            public void Add()
            {
                Console.WriteLine("Oracle Server Added");
            }

            public void Update()
            {
                Console.WriteLine("Oracle Server Updated");
            }

            public void Delete()
            {
                Console.WriteLine("Oracle Server Deleted");
            }
        }

        class MySql : ICustomer
        {
            public void Add()
            {
                Console.WriteLine("MySql Added");
            }

            public void Update()
            {
                Console.WriteLine("MySql Updated");
            }

            public void Delete()
            {
                Console.WriteLine("MySql Deleted");
            }
        }

        class CustomerManager
        {
            public void Add(ICustomer customer)
            {
                customer.Add();
            }
        }

    }
}
