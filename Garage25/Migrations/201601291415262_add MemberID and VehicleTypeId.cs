namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMemberIDandVehicleTypeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicles", "Member_MemberId", "dbo.Members");
            DropForeignKey("dbo.Vehicles", "VehicleType_VehicleTypeId", "dbo.VehicleTypes");
            DropIndex("dbo.Vehicles", new[] { "Member_MemberId" });
            DropIndex("dbo.Vehicles", new[] { "VehicleType_VehicleTypeId" });
            RenameColumn(table: "dbo.Vehicles", name: "Member_MemberId", newName: "MemberId");
            RenameColumn(table: "dbo.Vehicles", name: "VehicleType_VehicleTypeId", newName: "VehicleTypeId");
            AlterColumn("dbo.Vehicles", "MemberId", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehicles", "VehicleTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vehicles", "VehicleTypeId");
            CreateIndex("dbo.Vehicles", "MemberId");
            AddForeignKey("dbo.Vehicles", "MemberId", "dbo.Members", "MemberId", cascadeDelete: true);
            AddForeignKey("dbo.Vehicles", "VehicleTypeId", "dbo.VehicleTypes", "VehicleTypeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "VehicleTypeId", "dbo.VehicleTypes");
            DropForeignKey("dbo.Vehicles", "MemberId", "dbo.Members");
            DropIndex("dbo.Vehicles", new[] { "MemberId" });
            DropIndex("dbo.Vehicles", new[] { "VehicleTypeId" });
            AlterColumn("dbo.Vehicles", "VehicleTypeId", c => c.Int());
            AlterColumn("dbo.Vehicles", "MemberId", c => c.Int());
            RenameColumn(table: "dbo.Vehicles", name: "VehicleTypeId", newName: "VehicleType_VehicleTypeId");
            RenameColumn(table: "dbo.Vehicles", name: "MemberId", newName: "Member_MemberId");
            CreateIndex("dbo.Vehicles", "VehicleType_VehicleTypeId");
            CreateIndex("dbo.Vehicles", "Member_MemberId");
            AddForeignKey("dbo.Vehicles", "VehicleType_VehicleTypeId", "dbo.VehicleTypes", "VehicleTypeId");
            AddForeignKey("dbo.Vehicles", "Member_MemberId", "dbo.Members", "MemberId");
        }
    }
}
