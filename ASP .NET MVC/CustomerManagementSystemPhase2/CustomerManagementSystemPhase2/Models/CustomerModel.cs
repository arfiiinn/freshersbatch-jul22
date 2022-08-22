using BusinessLayer;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CustomerManagementSystemPhase2.Models
{
    public partial class CustomerModel : DbContext
    {
        public CustomerModel()
            : base("name=CustomerModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
