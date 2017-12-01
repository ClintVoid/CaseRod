namespace CaseRod.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAccessories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accessories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Name = c.String(),
                        PartNumber = c.String(),
                        Image = c.String(),
                        Price = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accessories");
        }
    }
}
