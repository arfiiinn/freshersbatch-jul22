namespace CustomerManagementSystemPhase2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CustomerManagementSystemPhase2.Models.CustomerModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CustomerManagementSystemPhase2.Models.CustomerModel";
        }

        protected override void Seed(CustomerManagementSystemPhase2.Models.CustomerModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
