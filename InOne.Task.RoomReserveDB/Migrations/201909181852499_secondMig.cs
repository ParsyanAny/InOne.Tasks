namespace InOne.Task.RoomReserveDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "IsEmpty", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "IsEmpty");
        }
    }
}
