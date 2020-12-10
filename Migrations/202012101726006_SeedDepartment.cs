namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDepartment : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Departments(DepartmentName)Values('IT')");
            Sql("Insert into Departments(DepartmentName)Values('HR')");
            Sql("Insert into Departments(DepartmentName)Values('Payroll')");
            Sql("Insert into Departments(DepartmentName)Values('Talent Acquisition')");
            Sql("Insert into Departments(DepartmentName)Values('Training & Development')");
        }
        
        public override void Down()
        {
        }
    }
}
