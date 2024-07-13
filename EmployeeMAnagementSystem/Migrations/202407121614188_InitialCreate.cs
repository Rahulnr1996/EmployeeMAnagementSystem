namespace EmployeeMAnagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employeeModels",
                c => new
                    {
                        employeeId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        place = c.String(),
                        description = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.employeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.employeeModels");
        }
    }
}
