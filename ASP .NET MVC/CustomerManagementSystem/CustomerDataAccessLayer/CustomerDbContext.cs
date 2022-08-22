using System;
using System.Data.Entity;
using CustomerBusinessLayer;

namespace CustomerDataAccessLayer
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext() : base("CustomerDb")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
