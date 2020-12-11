namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.String(nullable: false, maxLength: 128),
                        ContactName = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }

        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
