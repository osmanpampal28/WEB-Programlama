namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 50));
            AddColumn("dbo.Writers", "ShortAbout", c => c.String(maxLength: 100));
            AddColumn("dbo.Writers", "Mail", c => c.String(maxLength: 50));
            AddColumn("dbo.Writers", "Password", c => c.String(maxLength: 50));
            AddColumn("dbo.Writers", "PhoneNumber", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "PhoneNumber");
            DropColumn("dbo.Writers", "Password");
            DropColumn("dbo.Writers", "Mail");
            DropColumn("dbo.Writers", "ShortAbout");
            DropColumn("dbo.Writers", "WriterTitle");
        }
    }
}
