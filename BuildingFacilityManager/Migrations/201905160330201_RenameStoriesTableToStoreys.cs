namespace BuildingFacilityManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameStoriesTableToStoreys : DbMigration
    {
        public override void Up()
        {
            Sql(@"DROP TABLE dbo.Storyes");
        }
        
        public override void Down()
        {
        }
    }
}
