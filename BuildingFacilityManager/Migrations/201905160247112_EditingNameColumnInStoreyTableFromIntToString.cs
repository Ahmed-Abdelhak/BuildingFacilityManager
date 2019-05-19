namespace BuildingFacilityManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditingNameColumnInStoreyTableFromIntToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Stories", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Stories", "Name", c => c.Int(nullable: false));
        }
    }
}
