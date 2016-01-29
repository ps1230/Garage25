namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreinfoforMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Address", c => c.String());
            AddColumn("dbo.Members", "TelephoneNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "TelephoneNo");
            DropColumn("dbo.Members", "Address");
        }
    }
}
