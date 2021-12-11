namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmailSubscribes",
                c => new
                    {
                        EmailID = c.Int(nullable: false, identity: true),
                        EmailValue = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.EmailID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmailSubscribes");
        }
    }
}
