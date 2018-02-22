namespace IntroEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedrequiredminmaxLengthonCustomerandOrderproperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Customers", "City", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Customers", "State", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Orders", "OrderDescription", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "OrderDescription", c => c.String());
            AlterColumn("dbo.Customers", "State", c => c.String());
            AlterColumn("dbo.Customers", "City", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
