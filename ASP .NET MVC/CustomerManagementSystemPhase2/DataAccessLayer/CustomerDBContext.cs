using System;
using BusinessLayer;
using System.Data.Entity;
using System.Runtime;

namespace DataAccessLayer
{
    public class CustomerDBContext:DbContext
    {
        public CustomerDBContext() : base("CustomerDb")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}