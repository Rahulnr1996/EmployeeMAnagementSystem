namespace EmployeeMAnagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployeeModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.employeeModels", "name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.employeeModels", "place", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.employeeModels", "description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.employeeModels", "email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.employeeModels", "email", c => c.String());
            AlterColumn("dbo.employeeModels", "description", c => c.String());
            AlterColumn("dbo.employeeModels", "place", c => c.String());
            AlterColumn("dbo.employeeModels", "name", c => c.String());
        }
    }
}
