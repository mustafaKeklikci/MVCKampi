namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "WriteID", c => c.Int());
            CreateIndex("dbo.Contents", "WriteID");
            AddForeignKey("dbo.Contents", "WriteID", "dbo.Writes", "WriteID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "WriteID", "dbo.Writes");
            DropIndex("dbo.Contents", new[] { "WriteID" });
            DropColumn("dbo.Contents", "WriteID");
        }
    }
}
