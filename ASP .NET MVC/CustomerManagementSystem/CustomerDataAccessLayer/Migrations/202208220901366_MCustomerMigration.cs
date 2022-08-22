namespace CustomerDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MCustomerMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "Phone", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "Phone", c => c.Int(nullable: false));
        }
    }
}
