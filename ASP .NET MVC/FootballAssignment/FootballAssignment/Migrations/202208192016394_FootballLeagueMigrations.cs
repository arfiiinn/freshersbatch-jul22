namespace FootballAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FootballLeagueMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FootballLeagueforEF",
                c => new
                    {
                        MatchId = c.Int(nullable: false, identity: true),
                        TeamName1 = c.String(nullable: false),
                        TeamName2 = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        WinningTeam = c.String(),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatchId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FootballLeagueforEF");
        }
    }
}
