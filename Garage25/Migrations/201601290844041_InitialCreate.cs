namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        Lastname = c.String(),
                    })
                .PrimaryKey(t => t.MemberId);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        Color = c.String(),
                        Brand = c.String(),
                        Model = c.String(),
                        NumberOfWheels = c.Int(nullable: false),
                        ParkingTime = c.DateTime(nullable: false),
                        VehicleType_VehicleTypeId = c.Int(),
                        Member_MemberId = c.Int(),
                    })
                .PrimaryKey(t => t.VehicleId)
                .ForeignKey("dbo.VehicleTypes", t => t.VehicleType_VehicleTypeId)
                .ForeignKey("dbo.Members", t => t.Member_MemberId)
                .Index(t => t.VehicleType_VehicleTypeId)
                .Index(t => t.Member_MemberId);
            
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        VehicleTypeId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.VehicleTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "Member_MemberId", "dbo.Members");
            DropForeignKey("dbo.Vehicles", "VehicleType_VehicleTypeId", "dbo.VehicleTypes");
            DropIndex("dbo.Vehicles", new[] { "Member_MemberId" });
            DropIndex("dbo.Vehicles", new[] { "VehicleType_VehicleTypeId" });
            DropTable("dbo.VehicleTypes");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Members");
        }
    }
}
