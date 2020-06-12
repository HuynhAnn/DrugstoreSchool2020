namespace DrugstoreSchool2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Thuocs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenThuoc = c.String(nullable: false, maxLength: 255),
                        ThongTinThuoc = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        DiaChi = c.String(),
                        CategoryId = c.Byte(nullable: false),
                        DangThuoc_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.DangThuoc_Id)
                .Index(t => t.CategoryId)
                .Index(t => t.DangThuoc_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Thuocs", "DangThuoc_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Thuocs", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Thuocs", new[] { "DangThuoc_Id" });
            DropIndex("dbo.Thuocs", new[] { "CategoryId" });
            DropTable("dbo.Thuocs");
            DropTable("dbo.Categories");
        }
    }
}
