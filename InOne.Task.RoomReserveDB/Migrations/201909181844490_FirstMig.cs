namespace InOne.Task.RoomReserveDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Furnitures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(nullable: false, maxLength: 50),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReservationFurnitures",
                c => new
                    {
                        ReservationId = c.Int(nullable: false),
                        FurnitureId = c.Int(nullable: false),
                        Count = c.Int(),
                    })
                .PrimaryKey(t => new { t.ReservationId, t.FurnitureId });
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        ReservationTimeId = c.Int(nullable: false),
                        Time1 = c.DateTime(),
                        Time2 = c.DateTime(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReservationTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoomFurnitures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FurnitureId = c.Int(nullable: false),
                        ReservationId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        ParentRoomId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.ParentRoomId)
                .Index(t => t.ParentRoomId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 70),
                        BirthYear = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "ParentRoomId", "dbo.Rooms");
            DropIndex("dbo.Rooms", new[] { "ParentRoomId" });
            DropTable("dbo.Users");
            DropTable("dbo.Rooms");
            DropTable("dbo.RoomFurnitures");
            DropTable("dbo.ReservationTimes");
            DropTable("dbo.Reservations");
            DropTable("dbo.ReservationFurnitures");
            DropTable("dbo.Furnitures");
        }
    }
}
