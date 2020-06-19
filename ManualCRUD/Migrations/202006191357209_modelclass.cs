namespace ManualCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelclass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "Stream", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "Stream", c => c.Int(nullable: false));
        }
    }
}
