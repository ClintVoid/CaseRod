namespace CaseRod.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTextIDToName : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Texts");
            AlterColumn("dbo.Texts", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Texts", "Name");
            DropColumn("dbo.Texts", "TextID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Texts", "TextID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Texts");
            AlterColumn("dbo.Texts", "Name", c => c.String());
            AddPrimaryKey("dbo.Texts", "TextID");
        }
    }
}
