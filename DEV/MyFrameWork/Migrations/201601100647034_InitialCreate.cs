namespace MyFrameWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RealName = c.String(),
                        Age = c.Int(nullable: false),
                        Sex = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        PassWord = c.String(),
                        UserInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInfo", t => t.UserInfo_Id)
                .Index(t => t.UserInfo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserInfo_Id", "dbo.UserInfo");
            DropIndex("dbo.Users", new[] { "UserInfo_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.UserInfo");
        }
    }
}
