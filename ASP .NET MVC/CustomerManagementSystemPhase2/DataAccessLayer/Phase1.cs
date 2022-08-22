using BusinessLayer;
using System;
using System.Data.Entity;

namespace DataAccessLayer
{
    class Phase1
    {
        public static void Main()
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                Console.WriteLine("Customer Management System");
                Console.WriteLine("Add Customer Details");
                Console.WriteLine("Add Customer Name:");
                string CustomerName = Console.ReadLine();
                Console.WriteLine("Add City:");
                string City = Console.ReadLine();
                Console.WriteLine("Add Age:");
                int Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Add Phone Number:");
                double Phone = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Add Pincode:");
                int Pincode = Convert.ToInt32(Console.ReadLine());

                var customer = new Customer
                {
                    CustomerName = CustomerName,
                    City = City,
                    Age = Age,
                    Phone = Phone,
                    Pincode = Pincode
                };

                context.Customers.Add(customer);
                context.SaveChanges();

                Console.WriteLine("Retrieving Customers from Database");
                foreach (Customer acustomer in context.Customers)
                {
                    Console.WriteLine($"Customer ID: {acustomer.CustomerID}");
                    Console.WriteLine($"Customer Name: {acustomer.CustomerName}");
                    Console.WriteLine($"City: {acustomer.City}");
                    Console.WriteLine($"Age: {acustomer.Age}");
                    Console.WriteLine($"Phone: {acustomer.Phone}");
                    Console.WriteLine($"Pincode: {acustomer.Pincode}");
                }
            }
        }
    }
}
