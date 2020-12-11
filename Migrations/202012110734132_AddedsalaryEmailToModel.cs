namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedsalaryEmailToModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Employees", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Employees", "Salary");
        }
    }
}
