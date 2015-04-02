namespace POCEFDDD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", "IX_EMAIL");
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Users", "Email", unique: true, name: "IX_EMAIL");
        }
    }
}
