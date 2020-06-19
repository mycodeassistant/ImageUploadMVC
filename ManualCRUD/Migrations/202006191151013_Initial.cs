namespace ManualCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Stream = c.Int(nullable: false),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
        }
    }
}
