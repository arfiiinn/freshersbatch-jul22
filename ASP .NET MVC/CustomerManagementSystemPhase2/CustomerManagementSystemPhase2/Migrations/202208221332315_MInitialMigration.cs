﻿namespace CustomerManagementSystemPhase2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MInitialMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "CustomerName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "CustomerName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
