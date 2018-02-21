namespace IntroEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCityandState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "City", c => c.String());
            AddColumn("dbo.Customers", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "State");
            DropColumn("dbo.Customers", "City");
        }
    }
}
