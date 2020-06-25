namespace NHD.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiSaches",
                c => new
                    {
                        LoaiSachId = c.Int(nullable: false, identity: true),
                        TenLoai = c.String(),
                        MoTa = c.String(),
                    })
                .PrimaryKey(t => t.LoaiSachId);
            
            CreateTable(
                "dbo.Sach_LoaiSach",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SachId = c.Int(nullable: false),
                        LoaiSachId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LoaiSaches", t => t.LoaiSachId, cascadeDelete: true)
                .ForeignKey("dbo.Saches", t => t.SachId, cascadeDelete: true)
                .Index(t => t.SachId)
                .Index(t => t.LoaiSachId);
            
            CreateTable(
                "dbo.Saches",
                c => new
                    {
                        SachId = c.Int(nullable: false, identity: true),
                        TenSach = c.String(),
                        MoTa = c.String(),
                        NhaXuatBanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SachId)
                .ForeignKey("dbo.NhaXuatBans", t => t.NhaXuatBanId, cascadeDelete: true)
                .Index(t => t.NhaXuatBanId);
            
            CreateTable(
                "dbo.NhaXuatBans",
                c => new
                    {
                        NhaXuatBanId = c.Int(nullable: false, identity: true),
                        TenNhaXuatBan = c.String(),
                    })
                .PrimaryKey(t => t.NhaXuatBanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Saches", "NhaXuatBanId", "dbo.NhaXuatBans");
            DropForeignKey("dbo.Sach_LoaiSach", "SachId", "dbo.Saches");
            DropForeignKey("dbo.Sach_LoaiSach", "LoaiSachId", "dbo.LoaiSaches");
            DropIndex("dbo.Saches", new[] { "NhaXuatBanId" });
            DropIndex("dbo.Sach_LoaiSach", new[] { "LoaiSachId" });
            DropIndex("dbo.Sach_LoaiSach", new[] { "SachId" });
            DropTable("dbo.NhaXuatBans");
            DropTable("dbo.Saches");
            DropTable("dbo.Sach_LoaiSach");
            DropTable("dbo.LoaiSaches");
        }
    }
}
