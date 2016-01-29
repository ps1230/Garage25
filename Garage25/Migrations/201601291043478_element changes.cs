namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class elementchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "RegistrationNumber", c => c.String());
            AddColumn("dbo.Vehicles", "WheelCount", c => c.Int(nullable: false));
            AddColumn("dbo.Vehicles", "ParkTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Vehicles", "NumberOfWheels");
            DropColumn("dbo.Vehicles", "ParkingTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "ParkingTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Vehicles", "NumberOfWheels", c => c.Int(nullable: false));
            DropColumn("dbo.Vehicles", "ParkTime");
            DropColumn("dbo.Vehicles", "WheelCount");
            DropColumn("dbo.Vehicles", "RegistrationNumber");
        }
    }
}
