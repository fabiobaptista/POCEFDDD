namespace POCEFDDD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String(maxLength: 30));
            CreateIndex("dbo.Users", "Email", unique: true, name: "IX_EMAIL");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", "IX_EMAIL");
            DropColumn("dbo.Users", "Email");
        }
    }
}
