using CustomerBusinessLayer;
using CustomerDataAccessLayer;
using System.Data.Entity;

namespace Phase1
{
    public class Phase1
    {
        public static void Main(String[] args)
        {
            using (CustomerDbContext context = new CustomerDbContext())
            {
               /* Console.WriteLine("Customer Management System");
                Console.WriteLine("Add Customer Details");
                Console.WriteLine("Add Customer Name:");
                string? CustomerName = Console.ReadLine();
                Console.WriteLine("Add City:");
                string? City = Console.ReadLine();
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
                var customer1 = new Customer
                {
                    CustomerName = "Customer",
                    City = "City",
                    Age = 21,
                    Phone = 9898989891,
                    Pincode = 222222
                };
                var customer2 = new Customer
                {
                    CustomerName = "Customer",
                    City = "City",
                    Age = 21,
                    Phone = 9898989891,
                    Pincode = 222222
                };

                context.Customers.Add(customer);
                context.Customers.Add(customer1);
                context.Customers.Add(customer2);


                    context.SaveChanges(); */

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

