using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            Customer customer = new Customer();
            customer.FirstName = "Engin";

            Customer customer2 = new Customer
            {
                Id=2, City="ankara"
            };
            Console.WriteLine(customer2.Id +" " + customer2.City);
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }
        public void Update()
        {
            Console.WriteLine("Customer updated");
        }

    }
}
