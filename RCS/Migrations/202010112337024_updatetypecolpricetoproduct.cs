namespace RCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetypecolpricetoproduct : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "price", c => c.String());
        }
    }
}
