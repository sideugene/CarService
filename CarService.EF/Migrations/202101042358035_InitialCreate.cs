namespace CarService.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        Version = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Maintenance",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        ReservedDateTime = c.DateTime(nullable: false),
                        MaintenanceId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MarkUp = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            Sql("insert into [ServiceDB].[dbo].[ServiceType]([Name] ,[MarkUp]) values ('Glass tinting', 1234.5)");
            Sql("insert into [ServiceDB].[dbo].[ServiceType]([Name] ,[MarkUp]) values ('Pump up the wheels', 30.75)");
            Sql("insert into [ServiceDB].[dbo].[ServiceType]([Name] ,[MarkUp]) values ('Change color', 1000)");
            Sql("insert into [ServiceDB].[dbo].[ServiceType]([Name] ,[MarkUp]) values ('Add nitro', 100500)");
        }
        
        public override void Down()
        {
            DropTable("dbo.ServiceType");
            DropTable("dbo.Reservation");
            DropTable("dbo.Maintenance");
            DropTable("dbo.Customer");
            DropTable("dbo.Car");
        }
    }
}
